using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Threading_in_C.Players;

namespace Threading_in_C.Forms
{
    public partial class PlayerScreenForm : Form
    {

        private List<Player> players = new List<Player>();
        private int playerIndex = 0;
        public PlayerScreenForm()
        {
            InitializeComponent();
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
                existingPlayer.AR = (int)PlayerArmorRatingNumeric.Value;
                existingPlayer.BP = (int)PlayerProficiencyNumeric.Value;
                existingPlayer.Race = PlayerRaceTextbox.Text;
                existingPlayer.Class =  PlayerClassTextbox.Text;

                AddPlayerButton.Text = "Register Character";
                PlayerListBox.Items.Insert(player.PlayerIndex, player.ToString());
                ClearPlayerFields();
            }
            else
            {
                var player = new Player(playerIndex, PlayerNameTextbox.Text, 
                    (int)PlayerHealthNumeric.Value, 
                    (int)PlayerMovementNumeric.Value, 
                    (int)PlayerStrengthNumeric.Value, 
                    (int)PlayerDexterityNumeric.Value, 
                    (int)PlayerConstitutionNumeric.Value, 
                    (int)PlayerIntelligenceNumeric.Value, 
                    (int)PlayerWisdomNumeric.Value, 
                    (int)PlayerCharismaNumeric.Value, 
                    (int)PlayerArmorRatingNumeric.Value, 
                    (int)PlayerProficiencyNumeric.Value, 
                    null,
                    null);

                if (PlayerRaceTextbox.Text != null)
                {
                    player.Race = PlayerRaceTextbox.Text;
                }
                if (PlayerClassTextbox.Text != null)
                {
                    player.Class = PlayerClassTextbox.Text;
                }

                // Add the player to the ListBox control
                players.Add(player);
                playerIndex++;
                PlayerListBox.Items.Insert(player.PlayerIndex, player.ToString());
                ClearPlayerFields();

                PlayerBoard.intsance.placePlaceableOnPossibleTile(player);
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
                PlayerArmorRatingNumeric.Value = player.AR;
                PlayerProficiencyNumeric.Value = player.BP;
                PlayerRaceTextbox.Text = player.Race;
                PlayerClassTextbox.Text = player.Class;

                AddPlayerButton.Text = "Update Player";
            }
        }

        private void ClearPlayerFields()
        {
            PlayerNameTextbox.Text = "";
            PlayerRaceTextbox.Text = "";
            PlayerClassTextbox.Text = "";
            PlayerHealthNumeric.Value = 0;
            PlayerMovementNumeric.Value = 0;
            PlayerStrengthNumeric.Value = 0;
            PlayerDexterityNumeric.Value = 0;
            PlayerConstitutionNumeric.Value = 0;
            PlayerIntelligenceNumeric.Value = 0;
            PlayerWisdomNumeric.Value = 0;
            PlayerCharismaNumeric.Value = 0;
            PlayerArmorRatingNumeric.Value = 0;
            PlayerProficiencyNumeric.Value = 0;
        }
    }
}

