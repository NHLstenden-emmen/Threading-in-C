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
using Threading_in_C.Board;

namespace Threading_in_C
{
    public partial class PlayerBoard : Form
    {
        Tile[,] tileArray;
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
            int gridheight = 9;
            int gridwidth = 16;
            int tileSize = 80;

            //initialize tile array with the correct dimentions
            tileArray = new Tile[gridheight, gridwidth];

            //creates the buttons for the board and fills tile array with empty tiles
            for (int i = 0; i < gridheight; i++)
            {
                for (int j = 0; j < gridwidth; j++)
                {
                    Button button = new Button();
                    this.Controls.Add(button);
                    button.Size = new Size(tileSize, tileSize);
                    button.Location = new Point(initialX, initialY);
                    initialX += tileSize;

                    //sets button tags and onclick
                    button.Click += this.boardClick;
                    button.Tag = i + "-" + j;

                    //adds tile to the array
                    tileArray[gridheight-1, gridwidth-1] = new Tile();
                }
                initialX = 0;
                initialY += tileSize;
            }
        }

        private void boardClick(object sender, EventArgs e)
        {
            //catch off any sender object that is not a button
            if (!(sender is Button))
            {
                return;
            }
            //parse to button to enable all useses and fields
            Button button = (Button)sender;

            Console.WriteLine(button.Tag);
        }

        private void PlayerBoard_Load(object sender, EventArgs e)
        {
            setUpBoard();
        }

        private void moveObject(bool overrideRules = false)
        {
            if (!overrideRules)
            {

            }


        }
    }
}
