using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Threading_in_C.Board;
using Threading_in_C.Board.placeable;

namespace Threading_in_C
{
    public partial class PlayerBoard : Form
    {
        Button[,] tileArray;
        int gridheight = 9;
        int gridwidth = 16;
        int tileSize = 80;

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

            //initialize tile array with the correct dimentions
            tileArray = new Button[gridheight, gridwidth];

            //creates the buttons for the board and fills tile array with empty tiles
            for (int i = 0; i < gridheight; i++)
            {
                for (int j = 0; j < gridwidth; j++)
                {
                    //creates button and sets all atributes
                    Button button = new Button();
                    this.Controls.Add(button);
                    button.Size = new Size(tileSize, tileSize);
                    button.Location = new Point(initialX, initialY);
                    button.Click += this.boardClick;
                    
                    Tile tile = new Tile(j, i);
                    button.Tag = tile;

                    //adds button with tag to the array
                    tileArray[i, j] = button;

                    initialX += tileSize;
                }
                initialX = 0;
                initialY += tileSize;
            }
        }

        //updates the drawables on all tiles
        public void updateBoard()
        {
            for (int i = 0; i < gridheight; i++)
            {
                for(int j = 0; j < gridwidth; j++)
                {
                    Tile tile = (Tile)tileArray[i, j].Tag;
                    if (tile.getPlaceable() == null)
                    {
                        tileArray[i, j].Text = "";
                    }
                    else
                    {
                        tileArray[i,j].Text = tile.getPlaceable().getDrawAble();
                    }
                }
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

            //get the tile from the button
            Tile tile = (Tile)button.Tag;

            Console.WriteLine(tile);
        }

        private void PlayerBoard_Load(object sender, EventArgs e)
        {
            setUpBoard();

            //place players as test
            Tile buttonTile = (Tile)tileArray[1, 1].Tag;
            buttonTile.setPlaceable(new testPlayer("Roan"));
            updateBoard();
        }

        private void moveObject(bool overrideRules = false)
        {
            if (!overrideRules)
            {

            }


        }
    }
}
