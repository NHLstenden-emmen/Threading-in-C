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
    public partial class DungeonMasterUI : Form
    {
        public DungeonMasterUI()
        {
            InitializeComponent();

            // Creating a top menu bar
            MenuStrip menuBar = new MenuStrip();

            // Creating the menu bar items 
            ToolStripMenuItem playerMenu = new ToolStripMenuItem();
            playerMenu.Text = "Players"; 

            ToolStripMenuItem mapMenu = new ToolStripMenuItem();
            mapMenu.Text = "Map";

            ToolStripMenuItem monsterMenu = new ToolStripMenuItem();
            monsterMenu.Text = "Monsters";

            ToolStripMenuItem npcMenu = new ToolStripMenuItem();
            npcMenu.Text = "NPCs";

            ToolStripMenuItem settingMenu = new ToolStripMenuItem();
            settingMenu.Text = "Settings";

            // Add menu items to the menu bar
            menuBar.Items.Add(playerMenu);
            menuBar.Items.Add(mapMenu);
            menuBar.Items.Add(monsterMenu);
            menuBar.Items.Add(npcMenu);
            menuBar.Items.Add(settingMenu);

            // Creating a 3 column wide top menu bar
            TableLayoutPanel layoutPanel = new TableLayoutPanel();
            layoutPanel.Dock = DockStyle.Fill;
            layoutPanel.ColumnCount = 3;
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            layoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));

            // Adding the menu bar to the middle column 
            layoutPanel.Controls.Add(menuBar, 1, 0);
            
            // Center the menu bar within the column
            menuBar.Anchor = AnchorStyles.None;

            // Keep the bar at the top of the screen
            menuBar.Anchor |= AnchorStyles.Top;

            // Add the layout panel to the form
            this.Controls.Add(layoutPanel);

            // Here the size of the windows form can be set, for the main game it needs to be: , for programming a scaled down version of: 1920x1080 is used.
            this.Size = new Size(1920, 1080);
        }
    }
}
