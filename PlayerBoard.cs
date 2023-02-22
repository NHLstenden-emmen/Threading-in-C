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
    public partial class PlayerBoard : Form
    {
        public PlayerBoard()
        {
            FormBorderStyle = FormBorderStyle.None;
            // maar dan moet hij nog het andere scherm pakken

            InitializeComponent();
        }

        internal void ChangeLocation(int selectedScreen)
        {
            //Change form to normal, move form to different screen return to maximized mode.
            //this is needed because you can't move a form while it is maximized
            WindowState = FormWindowState.Normal;
            this.Location = Screen.AllScreens[selectedScreen].WorkingArea.Location;
            WindowState = FormWindowState.Maximized;
        }


        private void setUpBoard()
        {
            //creates the tiles in the board, based on the display size that is used for the game
            //the board that will be created is a grid of 16 by 9, with all the tiles being 80*80 pixels large

            int initialX = 0;
            int initialY = 0;
            int tileSize = 80;

            for (int i = 0; i <= 9; i++)
            {
                for (int j = 0; j <= 16; j++)
                {
                    Button button = new Button();
                    this.Controls.Add(button);
                    button.Size = new Size(tileSize, tileSize);
                    button.Location = new Point(initialX, initialY);
                    initialX += tileSize;
                }
                initialX = 0;
                initialY += tileSize;
            }
        }

        private void PlayerBoard_Load(object sender, EventArgs e)
        {
            setUpBoard();
        }
    }
}
