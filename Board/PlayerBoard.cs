﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using Threading_in_C.Board;
using Threading_in_C.Board.placeable;
using Threading_in_C.Entities;
using Threading_in_C.Players;

namespace Threading_in_C
{
    public partial class PlayerBoard : Form
    {
        Button[,] tileArray;
        int gridheight = 9;
        int gridwidth = 16;
        int tileSize = 80;
        Button selectedButton = null;
        public static PlayerBoard intsance;

        public PlayerBoard()
        {
            FormBorderStyle = FormBorderStyle.None;
            // maar dan moet hij nog het andere scherm pakken

            InitializeComponent();
            PlayerBoard.intsance = this;
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
                showAllPosibleMoves((Player)tile.getPlaceable(), tile);
                button.BackColor = Color.Green;
                return;
            }

            //unselect a button if the selected button is pressed again
            if (selectedButton == button)
            {
                selectedButton = null;
                DesellectAllPosibleMoves((Player)tile.getPlaceable(), tile);
                return;
            }

            //check if tile is empty
            if (tile.getPlaceable() != null)
            {
                return;
            }

            Tile selectedTile = (Tile)selectedButton.Tag;
            DesellectAllPosibleMoves((Player)selectedTile.getPlaceable(), selectedTile);
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
                buttonTile.setPlaceable(new Player(1, players[i], 100, 2, 10, 10, 10, 10, 10, 10, 10, 10, "Elf", "Dragonling"));
            }

            Tile RockTile = (Tile)tileArray[4, 5].Tag;
            RockTile.setPlaceable(new Obstacle("Rock"));

            Tile RockTile2 = (Tile)tileArray[5, 5].Tag;
            RockTile2.setPlaceable(new Obstacle("Rock"));

            Tile RockTile3 = (Tile)tileArray[6, 5].Tag;
            RockTile3.setPlaceable(new Obstacle("Rock"));

            updateBoard();
            exportBoard();
        }

        private List<Tile> getAllPosibleMoves(Moveable moveable, Tile location)
        {
            List<Tile> posibleMoves = new List<Tile>();
            List<Tile> upNext = new List<Tile>();

            upNext.Add(location);

            for (int i = 0; i <= moveable.getMovement(); i++)
            {
                //add all upnext moves to the possible move list
                foreach (Tile temptile in upNext)
                {
                    posibleMoves.Add(temptile);
                }

                //create a seperate list to store the temporary tiles that where just stored
                List<Tile> temp = new List<Tile>();

                foreach(Tile tile in upNext)
                {
                    temp.Add(tile);
                }

                upNext.Clear();

                foreach (Tile temptile in temp)
                {
                    Tile sideTile;

                    //check if tile upwards is posible
                    if (temptile.getY() > 0)
                    {
                        //find upwards tile
                        sideTile = (Tile)tileArray[temptile.getY() - 1, temptile.getX()].Tag;
                        if (!posibleMoves.Contains(sideTile) && !upNext.Contains(sideTile))
                        {
                            if (sideTile.getPlaceable() == null)
                            {
                                upNext.Add(sideTile);
                            }
                            else if(!sideTile.getPlaceable().GetType().IsSubclassOf(typeof(InMovable)))
                            {
                                upNext.Add(sideTile);
                            }
                        }
                    }

                    //check if tile downwards is posible
                    if (temptile.getY() < tileArray.GetLength(0) - 1)
                    {
                        //find downwards tile
                        sideTile = (Tile)tileArray[temptile.getY() + 1, temptile.getX()].Tag;
                        if (!posibleMoves.Contains(sideTile) && !upNext.Contains(sideTile))
                        {
                            if (sideTile.getPlaceable() == null)
                            {
                                upNext.Add(sideTile);
                            }
                            else if (!sideTile.getPlaceable().GetType().IsSubclassOf(typeof(InMovable)))
                            {
                                upNext.Add(sideTile);
                            }
                        }
                    }

                    //check if tile to the left is posible
                    if (temptile.getX() > 0)
                    {
                        //find tile to the left
                        sideTile = (Tile)tileArray[temptile.getY(), temptile.getX() - 1].Tag;
                        if (!posibleMoves.Contains(sideTile) && !upNext.Contains(sideTile))
                        {
                            if (sideTile.getPlaceable() == null)
                            {
                                upNext.Add(sideTile);
                            }
                            else if (!sideTile.getPlaceable().GetType().IsSubclassOf(typeof(InMovable)))
                            {
                                upNext.Add(sideTile);
                            }
                        }
                    }

                    //check if tile to the right is posible
                    if (temptile.getX() < tileArray.GetLength(1) - 1)
                    {
                        //find tile to the right
                        sideTile = (Tile)tileArray[temptile.getY(), temptile.getX() + 1].Tag;
                        if (!posibleMoves.Contains(sideTile) && !upNext.Contains(sideTile))
                        {
                            if (sideTile.getPlaceable() == null)
                            {
                                upNext.Add(sideTile);
                            }
                            else if (!sideTile.getPlaceable().GetType().IsSubclassOf(typeof(InMovable)))
                            {
                                upNext.Add(sideTile);
                            }
                        }
                    }
                }
            }

            return posibleMoves;
        }

        private void showAllPosibleMoves(Moveable moveable, Tile location)
        {
            foreach (Tile tile in getAllPosibleMoves(moveable, location))
            {
                tileArray[tile.getY(), tile.getX()].BackColor = Color.Blue;
            }
        }

        private void DesellectAllPosibleMoves(Moveable moveable, Tile location)
        {
            foreach (Tile tile in getAllPosibleMoves(moveable, location))
            {
                tileArray[tile.getY(), tile.getX()].BackColor = Color.Gray;
            }
        }

        public void placePlaceableOnPossibleTile(Placeable placeable)
        {
            foreach (Button button in tileArray)
            {
                Tile tile = (Tile)button.Tag;
                if (tile.getPlaceable() == null)
                {
                    tile.setPlaceable(placeable);
                    updateBoard();
                    return;
                }
            }
        }

        //export the drawables on all tiles
        public void exportBoard()
        {
            using (var stringWriter = new System.IO.StringWriter())
            {
                for (int i = 0; i < gridheight; i++)
                {
                    for (int j = 0; j < gridwidth; j++)
                    {
                        //Tile tile = (Tile)tileArray[i, j].Tag;
                        //if (tile.getPlaceable() != null && tile.getPlaceable().getDrawAble() != null)
                        //{ 
                        //    if(tile.getPlaceable().GetType() == typeof(Player) || true)
                        //    {
                        //        //Debug.WriteLine(tile.getPlaceable());
                        //        //Entity entity = (Entity)tile.getPlaceable();
                        //        using (var stringWriter = new System.IO.StringWriter())
                        //        {
                        //            var serializer = new XmlSerializer(tile.getPlaceable().GetType());
                        //            serializer.Serialize(stringWriter, tile.getPlaceable());
                        //            Debug.WriteLine(stringWriter.ToString());
                        //        }
                        //    }
                        //}
                        Tile tile = (Tile)tileArray[i, j].Tag;
                        if (tile.getPlaceable() != null && tile.getPlaceable().getDrawAble() != null)
                        {
                            //Debug.WriteLine(tile.placeable);
                            //Entity entity = (Entity)tile.getPlaceable();
                        
                            var serializer = new XmlSerializer(tile.GetType());
                            serializer.Serialize(stringWriter, tile);
                            Debug.WriteLine(stringWriter.ToString());
                        }
                    }
                }
                System.IO.File.WriteAllText("../../Resources/XML/test.xml", stringWriter.ToString());
            }
        }
    }
}
