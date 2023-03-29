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
            this.RefreshSavedEnemies = new System.Windows.Forms.Button();
            this.SavedEnemiesListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteEnemyButton
            // 
            this.DeleteEnemyButton.Location = new System.Drawing.Point(11, 600);
            this.DeleteEnemyButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEnemyButton.Name = "DeleteEnemyButton";
            this.DeleteEnemyButton.Size = new System.Drawing.Size(165, 59);
            this.DeleteEnemyButton.TabIndex = 24;
            this.DeleteEnemyButton.Text = "Delete Enemy";
            this.DeleteEnemyButton.UseVisualStyleBackColor = true;
            // 
            // GenerateMonsterButton
            // 
            this.GenerateMonsterButton.Location = new System.Drawing.Point(11, 32);
            this.GenerateMonsterButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateMonsterButton.Name = "GenerateMonsterButton";
            this.GenerateMonsterButton.Size = new System.Drawing.Size(104, 19);
            this.GenerateMonsterButton.TabIndex = 16;
            this.GenerateMonsterButton.Text = "Generate Monsters";
            this.GenerateMonsterButton.UseVisualStyleBackColor = true;
            this.GenerateMonsterButton.Click += new System.EventHandler(this.GenerateMonsterButton_Click);
            // 
            // MonsterAmount
            // 
            this.MonsterAmount.Location = new System.Drawing.Point(114, 32);
            this.MonsterAmount.Margin = new System.Windows.Forms.Padding(2);
            this.MonsterAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.MonsterAmount.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.MonsterAmount.Name = "MonsterAmount";
            this.MonsterAmount.Size = new System.Drawing.Size(33, 20);
            this.MonsterAmount.TabIndex = 15;
            this.MonsterAmount.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
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
            this.SavedEnemiesListBox.Location = new System.Drawing.Point(11, 69);
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
            this.Name = "MonstersScreenForm";
            this.Text = "MonstersScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.MonsterAmount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DeleteEnemyButton;
        private System.Windows.Forms.Button GenerateMonsterButton;
        private System.Windows.Forms.NumericUpDown MonsterAmount;
        private System.Windows.Forms.Button RefreshSavedEnemies;
        private System.Windows.Forms.ListBox SavedEnemiesListBox;
    }
}