using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
            Random rand = new Random();
            Dictionary<string, Dictionary<string, List<int>>> rollValues = new Dictionary<string, Dictionary<string, List<int>>>();

            for (int i = 1; i == createdGroupBoxes; i++)
            {
                string comboBoxName = "comboBoxDiceRoll" + i.ToString();
                rollValues.Add(comboBoxName, new Dictionary<string, List<int>>());

                int[] diceValues = { 4, 6, 8, 10, 12, 20, 100 };

                foreach (int diceValue in diceValues)
                {
                    string numericUpDownName = "numericUpDownD" + diceValue.ToString() + "Roll" + i.ToString();
                    int value = (int)((NumericUpDown)this.Controls.Find(numericUpDownName, true)[0]).Value;
                    int tag = (int)((NumericUpDown)this.Controls.Find(numericUpDownName, true)[0]).Tag;

                    // add the D value to Dictionary
                    rollValues[comboBoxName].Add("D" + tag, new List<int>());

                    // loop through the dice and get a random number between the max dice 
                    for (int k = 0; k < value; k++)
                    {
                        rollValues[comboBoxName]["D" + tag].Add(rand.Next(1, tag + 1));
                    }
                }
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