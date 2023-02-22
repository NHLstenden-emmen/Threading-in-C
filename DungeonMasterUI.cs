using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Threading_in_C
{
    public partial class DungeonMasterUI : Form
    {
        private Button currentButton;
        private Form activeForm;

        public DungeonMasterUI()
        {
            InitializeComponent();
        }

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
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
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
            OpenChildForm(new Forms.SettingsScreenForm(), sender);
        }
    }
}