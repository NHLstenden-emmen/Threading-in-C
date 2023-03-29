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

        public LootScreenForm()
        {
            InitializeComponent();
            RetrieveItemsFromDatabase();
            AddItemsToList();
        }

        // Displays all the items in the items list in the list box
        private void AddItemsToList()
        {
            foreach (Item item in items)
            {
                // Add the player to the ListBox control
                SavedItemsListBox.Items.Add(item.Name.ToString());
            }
        }

        private void RefreshSavedItems_Click(object sender, EventArgs e)
        {
            RetrieveItemsFromDatabase();
            AddItemsToList();
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
