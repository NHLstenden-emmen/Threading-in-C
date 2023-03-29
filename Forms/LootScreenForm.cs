using System;
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

        public LootScreenForm()
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
            for (int i = 0; i < AmountOfItems.Value; i++)
            {
                Interlocked.Increment(ref numThreads);
                Thread t = new Thread(new ThreadStart(PerformTask));
                t.Start();
            }

            // Wait for all threads to finish executing
            while (numThreads > 0)
            {
                threadExitEvent.WaitOne();
            }

            // Dispose of the ManualResetEvent object
            threadExitEvent.Set();
            using (threadExitEvent)
            {
                // do niks nie
            }
        }

        private void PerformTask()
        {
            // hier item aanmaken
            Item item;
            bool itemExist = true;
            while (itemExist)
            {
                item = ApiItemGenerator.Parse();

                dbMutex.WaitOne(); // acquire the mutex
                try
                {
                    itemExist = ItemExistsInDatabase(item.Name);
                    if (!itemExist)
                    {
                        AddItemToDatabase(item);
                    }
                }
                finally
                {
                    dbMutex.ReleaseMutex(); // release the mutex
                }
            }

            // Signal the thread to exit
            Interlocked.Decrement(ref numThreads);
            threadExitEvent.Set();
        }

        private void AddItemToDatabase(Item item)
        {
            OpenFiveApiRequest.con.Open();
            
            string insertSQL = "INSERT INTO Items (Name, Type, Rarity, Value, Description, Properties, Drawbacks, Requirements, History) VALUES (@Name, @Type, @Rarity, @Value, @Description, @Properties, @Drawbacks, @Requirements, @History)";

            using (SqlCommand command = new SqlCommand(insertSQL, OpenFiveApiRequest.con))
            {
                command.Parameters.AddWithValue("@Name", item.Name);
                command.Parameters.AddWithValue("@Type", item.Type);
                command.Parameters.AddWithValue("@Rarity", item.Rarity);
                command.Parameters.AddWithValue("@Value", item.Value);
                command.Parameters.AddWithValue("@Description", item.Description);
                command.Parameters.AddWithValue("@Properties", string.Join(";", item.Properties));
                command.Parameters.AddWithValue("@Drawbacks", string.Join(";", item.Drawbacks));
                command.Parameters.AddWithValue("@Requirements", string.Join(";", item.Requirements));
                command.Parameters.AddWithValue("@History", item.History);

                command.ExecuteNonQuery();
            }

            OpenFiveApiRequest.con.Close();
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
    }
}
