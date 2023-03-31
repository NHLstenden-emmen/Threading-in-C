﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Threading_in_C.ApiGenerators;
using Threading_in_C.ApiResponseAdapters;
using Threading_in_C.Entities;
using Threading_in_C.Equipment;
using Threading_in_C.OpenFiveApi;

namespace Threading_in_C.Forms
{
    public partial class LootScreenForm : Form
    {
        private List<Item> items = new List<Item>();
        private ManualResetEvent threadExitEvent = new ManualResetEvent(false);
        private int numThreads = 0;
        private Mutex dbMutex = new Mutex();
        ApiItemGenerator apiItemGenerator = new ApiItemGenerator();

        public LootScreenForm( )
        {
            InitializeComponent();
            RetrieveItemsFromDatabase();
            AddItemsToList();
        }

        // Retrieves all the items from the db and puts them in the items list
        private void RetrieveItemsFromDatabase()
        {
            OpenFiveApiRequest.con.Open();
            items.Clear();
            SavedItemsListBox.Items.Clear();

            string retrieveSQL = "SELECT * FROM Items";
            using (SqlCommand command = new SqlCommand(retrieveSQL, OpenFiveApiRequest.con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> properties = new List<string>();
                        string[] propertiesStrings = reader["Properties"].ToString().Split(';');
                        foreach (string propertiesString in propertiesStrings)
                        {
                            properties.Add(propertiesString);
                        }

                        List<string> drawbacks = new List<string>();
                        string[] drawbacksStrings = reader["Drawbacks"].ToString().Split(';');
                        foreach (string drawbacksString in drawbacksStrings)
                        {
                            drawbacks.Add(drawbacksString);
                        }

                        List<string> requirements = new List<string>();
                        string[] requirementsStrings = reader["Requirements"].ToString().Split(';');
                        foreach (string requirementsString in requirementsStrings)
                        {
                            requirements.Add(requirementsString);
                        }

                        Item item = new Item
                        (
                            reader["Name"].ToString(),
                            reader["Type"].ToString(),
                            reader["Rarity"].ToString(),
                            (int)reader["Value"],
                            reader["Description"].ToString(),
                            properties,
                            drawbacks,
                            requirements,
                            reader["history"].ToString()
                        );
                        items.Add(item);
                    }
                }
            }

            OpenFiveApiRequest.con.Close();
        }

        // Displays all the items in the items list in the list box
        private void AddItemsToList()
        {
            foreach (Item item in items)
            {
                // Add the item to the ListBox control
                SavedItemsListBox.Items.Add(item.ToString());
            }
        }

        private void RefreshSavedItems_Click(object sender, EventArgs e)
        {
            RetrieveItemsFromDatabase();
            AddItemsToList();
        }

        private void GenerateItemButton_Click(object sender, EventArgs e)
        {
            CreateThreads((int)AmountOfItems.Value);
            CleanupThreads();
        }

        private bool ItemExistsInDatabase(string ItemName)
        {
            bool itemExists = false;
            dbMutex.WaitOne(); // acquire the mutex
            try
            {
                OpenFiveApiRequest.con.Open();
                string retrieveSQL = "SELECT * FROM Items WHERE Name = @ItemName";
                using (SqlCommand command = new SqlCommand(retrieveSQL, OpenFiveApiRequest.con))
                {
                    command.Parameters.AddWithValue("@ItemName", ItemName);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            itemExists = true;
                        }
                    }
                }
                OpenFiveApiRequest.con.Close();
            }
            finally
            {
                dbMutex.ReleaseMutex(); // release the mutex
            }
            return itemExists;
        }

        // Method that tries to get a unique item up to three times
        private void PutNewItemInDatabase(Item item)
        {
            bool itemExist = ItemExistsInDatabase(item.Name);
            if (!itemExist)
            {
                apiItemGenerator.PutItemInDatabase(item);
            }
            else
            {
                int attempts = 0;
                Item newItem;
                do
                {
                    newItem = ApiItemGenerator.Parse();
                    itemExist = ItemExistsInDatabase(item.Name);
                    attempts++;
                } while (itemExist && attempts < 3);

                if (!itemExist)
                {
                    apiItemGenerator.PutItemInDatabase(newItem);
                }
            }
        }

        private void CreateThreads(int numThreadsToCreate)
        {
            for (int i = 0; i < numThreadsToCreate; i++)
            {
                Interlocked.Increment(ref numThreads);
                ManualResetEventSlim threadExitEvent = new ManualResetEventSlim(false);
                Thread t = new Thread(() => PerformTask(threadExitEvent));
                t.Start();
            }
        }

        private void PerformTask(ManualResetEventSlim threadExitEvent)
        {
            // create item
            var item = ApiItemGenerator.Parse();
            dbMutex.WaitOne(); // acquire the mutex
            try
            {
                // tries to get a unique item up to three times
                PutNewItemInDatabase(item);
            }
            finally
            {
                dbMutex.ReleaseMutex(); // release the mutex
            }

            // Signal the thread to exit
            Interlocked.Decrement(ref numThreads);
            threadExitEvent.Set();
        }

        private void CleanupThreads()
        {
            // Wait for all threads to exit
            while (numThreads > 0)
            {
                Thread.Sleep(10);
            }

            if (numThreads == 0)
            {
                RetrieveItemsFromDatabase();
                AddItemsToList();
            }
        }

        private void DeleteItem_Click(object sender, EventArgs e)
        {
            string deleteSQL = "DELETE FROM Items";
            using (SqlCommand command = new SqlCommand(deleteSQL, OpenFiveApiRequest.con))
            {
                OpenFiveApiRequest.con.Open();
                command.ExecuteNonQuery();
                OpenFiveApiRequest.con.Close();
            }
            RetrieveItemsFromDatabase();
            AddItemsToList();
        }

        private void SavedItemsListBox_DoubleClick(object sender, EventArgs e)
        {
            int index = ((ListBox)sender).SelectedIndex;
            DisplayLootScreenForm displayLootScreenForm = new DisplayLootScreenForm(items[index].ToFancyString());
            displayLootScreenForm.Show();
            Point point = Screen.AllScreens[MyApplicationContext.screenOfPlayerboard].WorkingArea.Location;
            point.X += 456;
            point.Y += 256;
            displayLootScreenForm.Location = point;

        }
    }
}