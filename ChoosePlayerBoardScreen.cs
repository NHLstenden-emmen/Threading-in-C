using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading_in_C
{
    public partial class ChoosePlayerBoardScreen : Form
    {
        protected int SelectedScreen;
        protected Screen[] screens = Screen.AllScreens;
        protected PlayerBoard boardPlayer;
        protected DungeonMasterUI boardDM;
        public ChoosePlayerBoardScreen(List<Form> forms)
        {
            boardPlayer = (PlayerBoard)forms[1];
            boardDM = (DungeonMasterUI)forms[0];
            this.FormBorderStyle= FormBorderStyle.None;
            InitializeComponent();
            // Loop through each screen and create a button for it
            for (int i = 0; i < screens.Length; i++)
            {
                Button button = new Button
                {
                    Text = "Monitor " + (i + 1),
                    Location = new Point(100, 50 + i * 30),
                    Tag = i
                };
                button.Click += new EventHandler(SelectWindow_Click);
                this.Controls.Add(button);
            }
            
        }

        private void SelectWindow_Click(object sender, EventArgs e)
        {
            SelectedScreen = (int)((Button)sender).Tag;
            boardPlayer.Show();
            boardPlayer.ChangeLocation(SelectedScreen);
            MyApplicationContext.screenOfPlayerboard = SelectedScreen;
            this.BringToFront();
        }


        private void SelectPlayerBoardScreen_Click(object sender, EventArgs e)
        {
            // TODO store location of screen in local storage
            // DMBoard = ChangeLocation(1 - SelectedScreen)
            if (screens.Length > 1)
            {
                boardDM.Show();
                boardDM.ChangeLocation(Math.Abs(1 - SelectedScreen));
                this.Close();
            }
            else
            {
                boardDM.Show();
                boardDM.ChangeLocation(SelectedScreen);
                this.Close();
            }
            boardPlayer.initiateBasicSetup(SelectedScreen);
        }
    }
}
