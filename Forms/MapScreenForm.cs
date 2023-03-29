using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            Placeable[,] map = new Placeable[PlayerBoard.intsance.gridheight, PlayerBoard.intsance.gridwidth];

            map[3, 3] = new Obstacle("Tree");
            map[7, 3] = new Obstacle("Tree");

            return map;
        }

        //create maps button click
        private void button2_Click(object sender, EventArgs e)
        {
            fillDisplayMap(MapExampleOne, generateRandomMap());
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
