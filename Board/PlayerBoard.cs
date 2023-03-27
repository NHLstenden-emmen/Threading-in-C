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
        Button selectedButton = null;

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
                    button.BackColor = Color.Gray;
                    
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

            //check if the tile is empty at first selection
            if (selectedButton == null && tile.getPlaceable() == null)
            {
                return;
            }

            //Check if the object is movable
            if (selectedButton == null && !tile.getPlaceable().GetType().IsSubclassOf(typeof(Moveable)))
            {
                return;
            }

            //select the pressed button if none other is selected
            if (selectedButton == null)
            {
                selectedButton = button;
                button.BackColor = Color.Green;
                return;
            }

            //unselect a button if the selected button is pressed again
            if (selectedButton == button)
            {
                selectedButton = null;
                button.BackColor = Color.Gray;
                return;
            }

            //check if tile is empty
            if (tile.getPlaceable() != null)
            {
                return;
            }

            Tile selectedTile = (Tile)selectedButton.Tag;
            tile.setPlaceable(selectedTile.getPlaceable());
            selectedTile.setPlaceable(null);
            selectedButton.BackColor = Color.Gray;
            selectedButton = null;
            updateBoard();
        }

        private void PlayerBoard_Load(object sender, EventArgs e)
        {
            
        }

        public void initiateBasicSetup(int SelectedScreen)
        {
            // Get the selected screen
            Screen selectedScreen = Screen.AllScreens[SelectedScreen];

            // Set the form to the size of the selected screen
            this.Location = selectedScreen.Bounds.Location;
            this.Size = selectedScreen.Bounds.Size;

            // Get the DPI of the selected screen
            Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);
            float dpiX = graphics.DpiX;
            float dpiY = graphics.DpiY;
            graphics.Dispose();

            setUpBoard();

            //place players as test
            List<String> players = new List<String>();
            players.Add("Roan");
            players.Add("Simchaja");
            players.Add("Daan");
            players.Add("Kevin");
            players.Add("Yaell");

            for (int i = 0; i < players.Count; i++)
            {
                Tile buttonTile = (Tile)tileArray[0, i].Tag;
                buttonTile.setPlaceable(new testPlayer(players[i]));
            }

            Tile RockTile = (Tile)tileArray[3, 5].Tag;
            RockTile.setPlaceable(new Obstacle("Rock"));



            updateBoard();
        }
    }
}
