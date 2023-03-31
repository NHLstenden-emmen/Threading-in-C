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
using Threading_in_C.Board.placeable;
using Threading_in_C.Players;

namespace Threading_in_C.Forms
{
    public partial class MapScreenForm : Form
    {
        public static MapScreenForm instance;
        public MapScreenForm()
        {
            InitializeComponent();
            MapScreenForm.instance = this;
        }

        public bool isMasterOverrideText()
        {
            return masterOverrideCheckbox.Checked;
        }

        private void obstacleButton_Click(object sender, EventArgs e)
        {
            PlayerBoard.instance.placePlaceableOnPossibleTile(new Obstacle(objectNameBox.Text));
        }

        public Placeable[,] generateRandomMap()
        {
            Random rnd = new Random();
            Placeable[,] map = new Placeable[PlayerBoard.instance.gridheight, PlayerBoard.instance.gridwidth];

            map = addrandomRoom(map);

            fillDisplayMap(MapExampleOne, map);

            map = addrandomRoom(map);

            fillDisplayMap(MapExampleOne, map);

            map = addrandomRoom(map);

            for (int i = 0; i < rnd.Next(1, 4); i++)
            {
                map[rnd.Next(0, PlayerBoard.instance.gridheight), rnd.Next(0, PlayerBoard.instance.gridwidth)] = new Obstacle("Tree");
            }

            for (int i = 0; i < rnd.Next(1, 4); i++)
            {
                map[rnd.Next(0, PlayerBoard.instance.gridheight), rnd.Next(0, PlayerBoard.instance.gridwidth)] = new Obstacle("Rock");
            }

            return map;
        }

        public Placeable[,] addrandomRoom(Placeable[,] map)
        {
            Random rnd = new Random();
            List<Point> room = Rooms.getRandomRoom(rnd.Next(0,PlayerBoard.instance.gridwidth - 4), rnd.Next(0, PlayerBoard.instance.gridheight - 4));

            foreach (Point p in room)
            {
                if(p.X <  PlayerBoard.instance.gridwidth && p.Y < PlayerBoard.instance.gridheight)
                {
                    map[p.Y,p.X] = new Obstacle("Wall");
                }
            }

            return map;
        }

        //create maps button click
        private void button2_Click(object sender, EventArgs e)
        {
            if (AmountOfMaps.Value >= 1)
            {
                fillDisplayMap(MapExampleOne, generateRandomMap());
            }
            if (AmountOfMaps.Value >= 2)
            {
                fillDisplayMap(MapExampleTwo, generateRandomMap());
            }
            if (AmountOfMaps.Value >= 3)
            {
                fillDisplayMap(MapExampleThree, generateRandomMap());
            }
            if (AmountOfMaps.Value >= 4)
            {
                fillDisplayMap(MapExampleFour, generateRandomMap());
            }
            if (AmountOfMaps.Value >= 5)
            {
                fillDisplayMap(MapExampleFive, generateRandomMap());
            }
            if (AmountOfMaps.Value >= 6)
            {
                fillDisplayMap(MapExampleSix, generateRandomMap());
            }
            if (AmountOfMaps.Value >= 7)
            {
                fillDisplayMap(MapExampleSeven, generateRandomMap());
            }
            if (AmountOfMaps.Value >= 8)
            {
                fillDisplayMap(MapExampleEight, generateRandomMap());
            }
            if (AmountOfMaps.Value == 9)
            {
                fillDisplayMap(MapExampleNine, generateRandomMap());
            }
        }

        private void fillDisplayMap(RichTextBox richTextBox, Placeable[,] map)
        {
            richTextBox.Text = "";
            for (int i = 0; i < PlayerBoard.instance.gridheight; i++)
            {
                for (int j = 0; j < PlayerBoard.instance.gridwidth; j++)
                {
                    if (map[i,j] != null)
                    {
                        richTextBox.Text += "■";
                    }
                    else
                    {
                        richTextBox.Text += "□";
                    }
                }

                richTextBox.Text += Environment.NewLine;
                richTextBox.Tag = map;
            }
        }

        private void SelectMap(object sender, EventArgs e)
        {
            RichTextBox richTextBox = sender as RichTextBox;
            if (richTextBox.Tag == null)
            {
                return;
            }

            Placeable[,] map = (Placeable[,])richTextBox.Tag;

            for (int i = 0; i < PlayerBoard.instance.gridheight; i++)
            {
                for (int j = 0; j < PlayerBoard.instance.gridwidth; j++)
                {
                    Tile tile = (Tile)PlayerBoard.instance.tileArray[i, j].Tag;

                    if (map[i,j] != null)
                    {
                        checkForPlayer(PlayerBoard.instance.tileArray, map, i, j);
                    }
                    else
                    {
                        if (tile.getPlaceable() == null || tile.getPlaceable().GetType() != typeof(Player))
                        {
                            tile.setPlaceable(null);
                        }
                    }
                }
            }

            PlayerBoard.instance.updateBoard();
            MapExampleOne.Text = "";
            MapExampleTwo.Text = "";
            MapExampleThree.Text = "";

            MapExampleOne.Tag = null;
            MapExampleTwo.Tag = null;
            MapExampleThree.Tag = null;
            MapExampleFour.Tag = null;
            MapExampleFive.Tag = null;
            MapExampleSix.Tag = null;
            MapExampleSeven.Tag = null;
            MapExampleEight.Tag = null;
            MapExampleNine.Tag = null;
        }

        private void checkForPlayer(Button[,] oldMap, Placeable[,] newMap, int i, int j)
        {
            Tile tile = (Tile)oldMap[i, j].Tag;
            if (tile.getPlaceable() != null && tile.getPlaceable().GetType() == typeof(Player))
            {
                checkForPlayer(oldMap, newMap, i, j + 1);
                Tile nextTile = (Tile)oldMap[i, j + 1].Tag;
                nextTile.setPlaceable(tile.getPlaceable());
            }
            tile.setPlaceable(newMap[i, j]);
        }
    }
}
