namespace Threading_in_C.Forms
{
    partial class MonstersScreenForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DeleteEnemyButton = new System.Windows.Forms.Button();
            this.GenerateMonsterButton = new System.Windows.Forms.Button();
            this.MonsterAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.DifficultyText = new System.Windows.Forms.TextBox();
            this.RefreshSavedEnemies = new System.Windows.Forms.Button();
            this.SavedEnemiesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteEnemyButton
            // 
            this.DeleteEnemyButton.Location = new System.Drawing.Point(11, 599);
            this.DeleteEnemyButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEnemyButton.Name = "DeleteEnemyButton";
            this.DeleteEnemyButton.Size = new System.Drawing.Size(165, 59);
            this.DeleteEnemyButton.TabIndex = 24;
            this.DeleteEnemyButton.Text = "Delete Enemy";
            this.DeleteEnemyButton.UseVisualStyleBackColor = true;
            // 
            // GenerateMonsterButton
            // 
            this.GenerateMonsterButton.Location = new System.Drawing.Point(140, 25);
            this.GenerateMonsterButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateMonsterButton.Name = "GenerateMonsterButton";
            this.GenerateMonsterButton.Size = new System.Drawing.Size(104, 19);
            this.GenerateMonsterButton.TabIndex = 16;
            this.GenerateMonsterButton.Text = "Generate Monsters";
            this.GenerateMonsterButton.UseVisualStyleBackColor = true;
            // 
            // MonsterAmount
            // 
            this.MonsterAmount.Location = new System.Drawing.Point(243, 25);
            this.MonsterAmount.Margin = new System.Windows.Forms.Padding(2);
            this.MonsterAmount.Name = "MonsterAmount";
            this.MonsterAmount.Size = new System.Drawing.Size(33, 20);
            this.MonsterAmount.TabIndex = 15;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(58, 26);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown2.TabIndex = 14;
            // 
            // DifficultyText
            // 
            this.DifficultyText.Enabled = false;
            this.DifficultyText.Location = new System.Drawing.Point(11, 26);
            this.DifficultyText.Margin = new System.Windows.Forms.Padding(2);
            this.DifficultyText.Name = "DifficultyText";
            this.DifficultyText.Size = new System.Drawing.Size(48, 20);
            this.DifficultyText.TabIndex = 13;
            this.DifficultyText.Text = "Difficulty";
            // 
            // RefreshSavedEnemies
            // 
            this.RefreshSavedEnemies.Location = new System.Drawing.Point(577, 600);
            this.RefreshSavedEnemies.Name = "RefreshSavedEnemies";
            this.RefreshSavedEnemies.Size = new System.Drawing.Size(75, 23);
            this.RefreshSavedEnemies.TabIndex = 25;
            this.RefreshSavedEnemies.Text = "Refresh";
            this.RefreshSavedEnemies.UseVisualStyleBackColor = true;
            this.RefreshSavedEnemies.Click += new System.EventHandler(this.RefreshSavedEnemies_Click);
            // 
            // SavedEnemiesListBox
            // 
            this.SavedEnemiesListBox.FormattingEnabled = true;
            this.SavedEnemiesListBox.Location = new System.Drawing.Point(11, 83);
            this.SavedEnemiesListBox.Name = "SavedEnemiesListBox";
            this.SavedEnemiesListBox.Size = new System.Drawing.Size(641, 511);
            this.SavedEnemiesListBox.TabIndex = 26;
            // 
            // MonstersScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 805);
            this.Controls.Add(this.SavedEnemiesListBox);
            this.Controls.Add(this.RefreshSavedEnemies);
            this.Controls.Add(this.DeleteEnemyButton);
            this.Controls.Add(this.GenerateMonsterButton);
            this.Controls.Add(this.MonsterAmount);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.DifficultyText);
            this.Name = "MonstersScreenForm";
            this.Text = "MonstersScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.MonsterAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteEnemyButton;
        private System.Windows.Forms.Button GenerateMonsterButton;
        private System.Windows.Forms.NumericUpDown MonsterAmount;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.TextBox DifficultyText;
        private System.Windows.Forms.Button RefreshSavedEnemies;
        private System.Windows.Forms.ListBox SavedEnemiesListBox;
    }
}