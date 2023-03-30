using System;
using System.IO;
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

        private void ImportGameButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, "../../Resources/XML"));
            openFileDialog1.Title = "Import Game";
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "XML files (*.xml)|*.xml";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                PlayerBoard.instance.importBoard(openFileDialog1.FileName);
            }
        }

        private void ExportGameButton_Click(object sender, EventArgs e)
        {
            PlayerBoard.instance.exportBoard();
        }
    }
}
