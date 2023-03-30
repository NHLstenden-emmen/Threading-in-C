using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Threading_in_C.ApiGenerators;
using Threading_in_C.ApiResponseAdapters;
using Threading_in_C.Entities;
using Threading_in_C.OpenFiveApi;

namespace Threading_in_C
{
    public partial class DungeonMasterUI : Form
    {
        private Button currentButton;
        private Form activeForm;
        public int turnCounter;
        private readonly OpenFiveApiRequest apiRequest= new OpenFiveApiRequest();
        private ApiEnemyGenerator apiEnemyGenerator = new ApiEnemyGenerator();
        private ApiNpcGenerator apiNpcGenerator = new ApiNpcGenerator();
        private ApiItemGenerator apiItemGenerator = new ApiItemGenerator();
        int createdGroupBoxes = 1;
        Random rand = new Random();
        Dictionary<string, Dictionary<string, List<int>>> rollValues = new Dictionary<string, Dictionary<string, List<int>>>();
        List<Thread> threads = new List<Thread>();


        public DungeonMasterUI()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Fill the combobox with the enemies
            SqlConnection connection = OpenFiveApiRequest.con;
            connection.Open();
            SqlCommand allEnemies = new SqlCommand("SELECT Name FROM Enemies", connection);
            SqlDataReader reader = allEnemies.ExecuteReader();
            while (reader.Read())
            {
                // Add each player name to the ComboBox
                string playerName = reader.GetString(0);
                comboBoxDiceRoll1.Items.Add(playerName);
            }

            // Close the connection and dispose of the command and reader objects
            reader.Close();
            allEnemies.Dispose();
            connection.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        internal void ChangeLocation(int selectedScreen)
        {
            //Change form to normal, move form to different screen return to maximized mode.
            //this is needed because you can't move a form while it is maximized
            WindowState = FormWindowState.Normal;
            this.Location = Screen.AllScreens[selectedScreen].WorkingArea.Location;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Gray;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    if (previousBtn.Name != "btnClose" && previousBtn.Name != "bntMinimize" && previousBtn.Name != "btnTurnCounter")
                    {
                        previousBtn.BackColor = Color.Black;
                        previousBtn.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                if (childForm.Text != activeForm.Text)
                {
                    activeForm.Close();
                    ActivateButton(btnSender);
                    activeForm = childForm;
                    childForm.TopLevel = false;
                    childForm.FormBorderStyle = FormBorderStyle.None;
                    childForm.Dock = DockStyle.Fill;
                    this.panelContentScreen.Controls.Add(childForm);
                    this.panelContentScreen.Tag = childForm;
                    childForm.BringToFront();
                    childForm.Show();
                }
            } else
            {
                ActivateButton(btnSender);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                this.panelContentScreen.Controls.Add(childForm);
                this.panelContentScreen.Tag = childForm;
                childForm.BringToFront();
                childForm.Show();
            }

        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.PlayerScreenForm(), sender);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MapScreenForm(), sender);
        }

        private void btnMonsters_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.MonstersScreenForm(), sender);
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.NpcScreenForm(), sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.SettingsScreenForm(this), sender);
        }
        private void btnLoot_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LootScreenForm(), sender);
        }

        private void panelMenu_MouseDown(object sender, MouseEventArgs e)
        {

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bntMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnTurnCounter_Click(object sender, EventArgs e)
        {
            turnCounter++;
            btnTurnCounter.Text = turnCounter.ToString();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activeForm.Close();

        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            rollValues.Clear();

            for (int i = 1; i <= createdGroupBoxes; i++)
            {
                string comboBoxName = "comboBoxDiceRoll" + i.ToString();
                ComboBox comboBox = (ComboBox)this.Controls.Find(comboBoxName, true)[0];

                comboBoxName = comboBox.Text;

                int[] diceValues = { 4, 6, 8, 10, 12, 20, 100 };

                // check if any of the dice have a value
                bool hasValue = false;
                foreach (int diceValue in diceValues)
                {
                    string numericUpDownName = "numericUpDownD" + diceValue.ToString() + "Roll" + i.ToString();
                    int value = (int)((NumericUpDown)this.Controls.Find(numericUpDownName, true)[0]).Value;
                    if (value > 0)
                    {
                        if (!rollValues.ContainsKey(comboBoxName))
                        {
                            rollValues.Add(comboBoxName, new Dictionary<string, List<int>>());
                        }
                        hasValue = true;
                        int tag = Convert.ToInt32(((NumericUpDown)this.Controls.Find(numericUpDownName, true)[0]).Tag);

                        // nieuwe thread for nieuwe dice rolls
                        Thread thread = new Thread(() => RollDice(comboBoxName, diceValue, i, value, tag));
                        threads.Add(thread);
                        thread.Start();
                    }
                }

                // if none of the dice have a value, skip the comboBox
                if (!hasValue)
                {
                    continue;
                }
            }

            // wait for all the threads to finish before moving on
            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            DisplayRollValueText();
        }

        private void DisplayRollValueText() 
        {
            // create a new string builder to store the results
            StringBuilder sb = new StringBuilder();


            // loop through the rollValues dictionary
            foreach (string comboBoxName in rollValues.Keys)
            {
                sb.AppendLine(comboBoxName + ":");

                foreach (string dice in rollValues[comboBoxName].Keys)
                {
                    sb.AppendLine("" + dice + ": " + string.Join(", ", rollValues[comboBoxName][dice]));
                }

                sb.AppendLine();
            }

            // display the results in a multi-line text box or list box

            richTextBox1.Text = sb.ToString();
        }

        // method to roll the dice and add the values to the dictionary
        private void RollDice(string comboBoxName, int diceValue, int i, int value, int tag)
        {
            Random rand = new Random();
            List<int> rolls = new List<int>();

            // generate the random numbers
            for (int k = 0; k < value; k++)
            {
                int roll = rand.Next(1, tag);
                rolls.Add(roll);
            }

            // add the rolls to the dictionary
            lock (rollValues)
            {
                if (!rollValues[comboBoxName].ContainsKey("D" + tag))
                {
                    rollValues[comboBoxName].Add("D" + tag, new List<int>());
                }

                rollValues[comboBoxName]["D" + tag].AddRange(rolls);
            }
        }

        private void btnAddNewDiceRoll_Click(object sender, EventArgs e)
        {
            GroupBox groupBoxCopy = new GroupBox();

            if (createdGroupBoxes < 4)
            {
                groupBoxCopy.Location = new Point(30, RollTheDice.Location.Y + ((RollTheDice.Size.Height + 20) * createdGroupBoxes));
            }
            else if (createdGroupBoxes < 8)
            {
                groupBoxCopy.Location = new Point(RollTheDice.Location.X + RollTheDice.Size.Width + 150, RollTheDice.Location.Y + ((RollTheDice.Size.Height + 20) * (createdGroupBoxes - 4)));
            }
            else
            {
                MessageBox.Show("Max dobbelsteen roll's behaald");
                return;
            }
            createdGroupBoxes++;

            groupBoxCopy.Size = RollTheDice.Size;

            foreach (Control control in RollTheDice.Controls)
            {
                Control controlCopy = (Control)Activator.CreateInstance(control.GetType());
                controlCopy.Location = control.Location;
                controlCopy.Name = control.Name.Remove(control.Name.Length -1) + createdGroupBoxes;
                controlCopy.Size = control.Size;
                controlCopy.Text = control.Text;
                controlCopy.Tag = control.Tag;
                if (control is ComboBox)
                {
                    ComboBox comboBox = control as ComboBox;
                    ComboBox comboBoxCopy = controlCopy as ComboBox;

                    foreach (var item in comboBox.Items)
                    {
                        comboBoxCopy.Items.Add(item);
                    }
                }

                groupBoxCopy.Controls.Add(controlCopy);
            }

            this.panelContentScreen.Controls.Add(groupBoxCopy);
        }
    }
}