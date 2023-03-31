using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Threading_in_C.Board;
using Threading_in_C.Board.placeable;
using Threading_in_C.Players;

namespace Threading_in_C.Forms
{
    public partial class MapScreenForm : Form
    {
        private RichTextBox[] richTextBoxes;
        public static MapScreenForm instance;
        public MapScreenForm()
        {
            InitializeComponent();
            MapScreenForm.instance = this;
            richTextBoxes = new RichTextBox[] 
            {
                MapExampleOne,
                MapExampleTwo,
                MapExampleThree,
                MapExampleFour,
                MapExampleFive,
                MapExampleSix,
                MapExampleSeven,
                MapExampleEight,
                MapExampleNine
            };
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
            ThreadLocal<Random> rand = new ThreadLocal<Random>(() => new Random());
            Random rnd = rand.Value;
            Placeable[,] map = new Placeable[PlayerBoard.instance.gridheight, PlayerBoard.instance.gridwidth];

            // Sleep for 20 ms so the random numbers are unique
            map = addrandomRoom(map);
            Thread.Sleep(20);
            map = addrandomRoom(map);
            Thread.Sleep(20);
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

        public static Placeable[,] addrandomRoom(Placeable[,] map)
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
            Placeable[,] result = new Placeable[PlayerBoard.instance.gridheight, PlayerBoard.instance.gridwidth];
            List<Placeable[,]> mapList = new List<Placeable[,]>();
            int numMaps = (int)AmountOfMaps.Value;
            Object randLock = new Object();
            ManualResetEvent[] events = new ManualResetEvent[numMaps];

            for (int i = 0; i < numMaps; i++)
            {
                int mapId = i;
                events[mapId] = new ManualResetEvent(false);
                ThreadPool.QueueUserWorkItem(new WaitCallback(
                    (_) =>
                    {
                        lock (randLock)
                        {
                            mapList.Add(generateRandomMap());
                        }
                        events[mapId].Set();
                    }
                ));
            }
            Thread waitThread = new Thread(() =>
            {
                WaitHandle.WaitAll(events);
            });

            waitThread.SetApartmentState(ApartmentState.MTA);
            waitThread.Start();
            waitThread.Join();

            for (int mapId = 0; mapId < AmountOfMaps.Value; mapId++)
            {
                fillDisplayMap(richTextBoxes[mapId], mapList[mapId]);
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
            foreach (RichTextBox textBox in richTextBoxes)
            {
                textBox.Tag = null;
                textBox.Text = "";
            }
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
