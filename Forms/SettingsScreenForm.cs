using System;
using System.Windows.Forms;


namespace Threading_in_C.Forms
{
    public partial class SettingsScreenForm : Form
    {
        private DungeonMasterUI DungeonMasterUIInstance;
        public SettingsScreenForm(DungeonMasterUI dungeonMasterUI)
        {
            InitializeComponent();
            DungeonMasterUIInstance = dungeonMasterUI;
        }

        private void btnResetTurnCounter_Click(object sender, EventArgs e)
        {
            int resetedTurns = DungeonMasterUIInstance.turnCounter = 0;
            DungeonMasterUIInstance.btnTurnCounter.Text = resetedTurns.ToString();
        }
    }
}
