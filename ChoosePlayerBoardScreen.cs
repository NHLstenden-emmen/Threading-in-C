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
    public partial class ChoosePlayerBoardScreen : Form
    {
        public ChoosePlayerBoardScreen()
        {
            InitializeComponent();
            Screen[] screens = Screen.AllScreens;
            Screen thisScreen = Screen.FromControl(this);
            foreach (Screen screen in screens)
            {
                //display each screen on the form

            }
        }
    }
}
