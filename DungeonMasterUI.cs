﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

        private void DungeonMasterUI_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void AddPlayerButton_Click(object sender, EventArgs e)
        {
            var player = new Player();

            // Check if the player already exists
            if (players.Any(p => p.Name == PlayerNameTextbox.Text))
            {
                MessageBox.Show("Player with the same name already exists.");
                return;
            }

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
            PlayerListBox.Items.Add(player.Name);
        }

        private void PlayerListBox_SelectedIndexChanged(Object sender, EventArgs e)
        {
            // Get the selected player
            var player = players[PlayerListBox.SelectedIndex];
        }

        private void PlayerDexterityNumeric_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void DeletePlayerButton_Click(object sender, EventArgs e)
        {
            // Get the selected player from the list box
            var selectedPlayerName = PlayerListBox.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(selectedPlayerName))
            {
                MessageBox.Show("Please select a player to delete.");
                return;
            }

            // Find the player in the list of players
            var selectedPlayer = players.FirstOrDefault(p => p.Name == selectedPlayerName);
            if (selectedPlayer == null)
            {
                MessageBox.Show("Selected player was not found.");
                return;
            }

            // Remove the player from the list of players and the list box
            players.Remove(selectedPlayer);
            PlayerListBox.Items.Remove(selectedPlayerName);

            MessageBox.Show("Player deleted successfully.");
        }
    }
}