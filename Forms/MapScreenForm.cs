using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Threading_in_C.Board;
using Threading_in_C.Board.placeable;

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
            PlayerBoard.intsance.placePlaceableOnPossibleTile(new Obstacle(objectNameBox.Text));
        }

        public Placeable[,] generateRandomMap()
        {
            Random rnd = new Random();
            Placeable[,] map = new Placeable[PlayerBoard.intsance.gridheight, PlayerBoard.intsance.gridwidth];

            map = addrandomRoom(map);

            fillDisplayMap(MapExampleOne, map);

            map = addrandomRoom(map);

            fillDisplayMap(MapExampleOne, map);

            map = addrandomRoom(map);

            map[rnd.Next(0, PlayerBoard.intsance.gridheight), rnd.Next(0, PlayerBoard.intsance.gridwidth)] = new Obstacle("tree");
            map[rnd.Next(0, PlayerBoard.intsance.gridheight), rnd.Next(0, PlayerBoard.intsance.gridwidth)] = new Obstacle("tree");

            return map;
        }

        public Placeable[,] addrandomRoom(Placeable[,] map)
        {
            Random rnd = new Random();
            List<Point> room = Rooms.getRandomRoom(rnd.Next(0,PlayerBoard.intsance.gridwidth - 4), rnd.Next(0, PlayerBoard.intsance.gridheight - 4));

            foreach (Point p in room)
            {
                if(p.X <  PlayerBoard.intsance.gridwidth && p.Y < PlayerBoard.intsance.gridheight)
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
            if (AmountOfMaps.Value == 3)
            {
                fillDisplayMap(MapExampleThree, generateRandomMap());
            }
        }

        private void fillDisplayMap(RichTextBox richTextBox, Placeable[,] map)
        {
            richTextBox.Text = "";
            for (int i = 0; i < PlayerBoard.intsance.gridheight; i++)
            {
                for (int j = 0; j < PlayerBoard.intsance.gridwidth; j++)
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
    }
}
