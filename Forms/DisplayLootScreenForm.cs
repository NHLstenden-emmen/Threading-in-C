using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading_in_C.Forms
{
    public partial class DisplayLootScreenForm : Form
    {
        public DisplayLootScreenForm(String lootInfo)
        {
            InitializeComponent();
            textBoxLootInfo.Text = lootInfo;
        }

        private void DisplayLootScreenForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
