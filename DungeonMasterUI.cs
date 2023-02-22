using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Threading_in_C.Players;

namespace Threading_in_C
{
    public partial class DungeonMasterUI : Form
    {
        private List<Player> players = new List<Player> ();
        public DungeonMasterUI()
        {
            InitializeComponent();
        }

        internal void ChangeLocation(int selectedScreen)
        {
            //Change form to normal, move form to different screen return to maximized mode.
            //this is needed because you can't move a form while it is maximized
            WindowState = FormWindowState.Normal;
            this.Location = Screen.AllScreens[selectedScreen].WorkingArea.Location;
        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            var existingPlayer = players.FirstOrDefault(p => p.Name == PlayerNameTextbox.Text);

            if (existingPlayer != null)
            {
                if (AddPlayerButton.Text == "Register Character")
                {
                    return;
                }
                var player = players[PlayerListBox.SelectedIndex];
                PlayerListBox.Items.Remove(player.ToString());

                existingPlayer.Health = (int)PlayerHealthNumeric.Value;
                existingPlayer.Movement = (int)PlayerMovementNumeric.Value;
                existingPlayer.Strength = (int)PlayerStrengthNumeric.Value;
                existingPlayer.Dexterity = (int)PlayerDexterityNumeric.Value;
                existingPlayer.Constitution = (int)PlayerConstitutionNumeric.Value;
                existingPlayer.Intelligence = (int)PlayerIntelligenceNumeric.Value;
                existingPlayer.Wisdom = (int)PlayerWisdomNumeric.Value;
                existingPlayer.Charisma = (int)PlayerCharismaNumeric.Value;

                AddPlayerButton.Text = "Register Character";
                PlayerListBox.Items.Add(player.ToString());
            }
            else
            {
                var player = new Player(PlayerNameTextbox.Text, (int)PlayerHealthNumeric.Value, (int)PlayerMovementNumeric.Value, (int)PlayerStrengthNumeric.Value, (int)PlayerDexterityNumeric.Value, (int)PlayerConstitutionNumeric.Value, (int)PlayerIntelligenceNumeric.Value, (int)PlayerWisdomNumeric.Value, (int)PlayerCharismaNumeric.Value, 1, 1, null, null, null, null);
                player.Name = PlayerNameTextbox.Text;
                player.Health = (int)PlayerHealthNumeric.Value;
                player.Movement = (int)PlayerMovementNumeric.Value;
                player.Strength = (int)PlayerStrengthNumeric.Value;
                player.Dexterity = (int)PlayerDexterityNumeric.Value;
                player.Constitution = (int)PlayerConstitutionNumeric.Value;
                player.Intelligence = (int)PlayerIntelligenceNumeric.Value;
                player.Wisdom = (int)PlayerWisdomNumeric.Value;
                player.Charisma = (int)PlayerCharismaNumeric.Value;

                // Add the player to the ListBox control
                players.Add(player);
                PlayerListBox.Items.Add(player.ToString());
            }
        }

        private void PlayerListBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            // Get the selected player
            var player = players[PlayerListBox.SelectedIndex];
        }

        private void ChangePlayerAttributes_Click(object sender, EventArgs e)
        {
            if (PlayerListBox.SelectedIndex >= 0)
            {
                var player = players[PlayerListBox.SelectedIndex];

                PlayerHealthNumeric.Value = player.Health;
                PlayerMovementNumeric.Value = player.Movement;
                PlayerStrengthNumeric.Value = player.Strength;
                PlayerDexterityNumeric.Value = player.Dexterity;
                PlayerConstitutionNumeric.Value = player.Constitution;
                PlayerIntelligenceNumeric.Value = player.Intelligence;
                PlayerWisdomNumeric.Value = player.Wisdom;
                PlayerCharismaNumeric.Value = player.Charisma;
                PlayerNameTextbox.Text = player.Name;

                AddPlayerButton.Text = "Update Player";
            }
        }
    }
}