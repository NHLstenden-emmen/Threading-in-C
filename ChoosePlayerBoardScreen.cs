using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public ChoosePlayerBoardScreen()
        {
            InitializeComponent();
            // Loop through each screen and create a button for it
            for (int i = 0; i < screens.Length; i++)
            {
                Button button = new Button();
                button.Text = "Monitor " + (i + 1);
                button.Location = new Point(10, 10 + i * 30);
                button.Click += (sender, e) =>
                {
                    SelectedScreen = i;
                };
                this.Controls.Add(button);
            }
        }

        private void SelectPlayerBoardScreen_Click(object sender, EventArgs e)
        {
            this.Location = screens[SelectedScreen].WorkingArea.Location;
            new PlayerBoard().Show();
        }
    }
}
