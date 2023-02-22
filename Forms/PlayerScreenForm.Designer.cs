namespace Threading_in_C.Forms
{
    partial class PlayerScreenForm
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
            this.ChangePlayerAttributes = new System.Windows.Forms.Button();
            this.AddPlayerButton = new System.Windows.Forms.Button();
            this.PlayerCreationGroupBox = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PlayerCharismaNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerWisdomNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerIntelligenceNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerConstitutionNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerDexterityNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerStrengthNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerMovementNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerHealthNumeric = new System.Windows.Forms.NumericUpDown();
            this.PlayerNameTextbox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PlayerHealthLabel = new System.Windows.Forms.Label();
            this.PlayerMovementLabel = new System.Windows.Forms.Label();
            this.PlayerStrengthLabel = new System.Windows.Forms.Label();
            this.PlayerConstitutionLabel = new System.Windows.Forms.Label();
            this.PlayerDexterityLabel = new System.Windows.Forms.Label();
            this.PlayerCharismaLabel = new System.Windows.Forms.Label();
            this.PlayerIntelligenceLabel = new System.Windows.Forms.Label();
            this.PlayerWisdomLabel = new System.Windows.Forms.Label();
            this.PlayerListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.PlayerCreationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCharismaNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerWisdomNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerIntelligenceNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerConstitutionNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDexterityNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerStrengthNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMovementNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealthNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePlayerAttributes
            // 
            this.ChangePlayerAttributes.Location = new System.Drawing.Point(21, 678);
            this.ChangePlayerAttributes.Name = "ChangePlayerAttributes";
            this.ChangePlayerAttributes.Size = new System.Drawing.Size(111, 23);
            this.ChangePlayerAttributes.TabIndex = 17;
            this.ChangePlayerAttributes.Text = "Edit Player";
            this.ChangePlayerAttributes.UseVisualStyleBackColor = true;
            this.ChangePlayerAttributes.Click += new System.EventHandler(this.ChangePlayerAttributes_Click);
            // 
            // AddPlayerButton
            // 
            this.AddPlayerButton.Location = new System.Drawing.Point(116, 379);
            this.AddPlayerButton.Name = "AddPlayerButton";
            this.AddPlayerButton.Size = new System.Drawing.Size(111, 23);
            this.AddPlayerButton.TabIndex = 16;
            this.AddPlayerButton.Text = "Register Character";
            this.AddPlayerButton.UseVisualStyleBackColor = true;
            this.AddPlayerButton.Click += new System.EventHandler(this.AddPlayerButton_Click);
            // 
            // PlayerCreationGroupBox
            // 
            this.PlayerCreationGroupBox.BackgroundImage = global::Threading_in_C.Properties.Resources.magicitemcards_template_front_poker;
            this.PlayerCreationGroupBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PlayerCreationGroupBox.Controls.Add(this.pictureBox1);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerCharismaNumeric);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerWisdomNumeric);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerIntelligenceNumeric);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerConstitutionNumeric);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerDexterityNumeric);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerStrengthNumeric);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerMovementNumeric);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerHealthNumeric);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerNameTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.NameLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerHealthLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerMovementLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerStrengthLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerConstitutionLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerDexterityLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerCharismaLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerIntelligenceLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerWisdomLabel);
            this.PlayerCreationGroupBox.Font = new System.Drawing.Font("Viner Hand ITC", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerCreationGroupBox.Location = new System.Drawing.Point(21, 12);
            this.PlayerCreationGroupBox.Name = "PlayerCreationGroupBox";
            this.PlayerCreationGroupBox.Size = new System.Drawing.Size(295, 380);
            this.PlayerCreationGroupBox.TabIndex = 15;
            this.PlayerCreationGroupBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Threading_in_C.Properties.Resources.DnD_Symbol;
            this.pictureBox1.Location = new System.Drawing.Point(52, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(185, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // PlayerCharismaNumeric
            // 
            this.PlayerCharismaNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerCharismaNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerCharismaNumeric.Location = new System.Drawing.Point(217, 338);
            this.PlayerCharismaNumeric.Name = "PlayerCharismaNumeric";
            this.PlayerCharismaNumeric.Size = new System.Drawing.Size(40, 21);
            this.PlayerCharismaNumeric.TabIndex = 25;
            this.PlayerCharismaNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerCharismaNumeric.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // PlayerWisdomNumeric
            // 
            this.PlayerWisdomNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerWisdomNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerWisdomNumeric.Location = new System.Drawing.Point(217, 311);
            this.PlayerWisdomNumeric.Name = "PlayerWisdomNumeric";
            this.PlayerWisdomNumeric.Size = new System.Drawing.Size(40, 21);
            this.PlayerWisdomNumeric.TabIndex = 24;
            this.PlayerWisdomNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerWisdomNumeric.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // PlayerIntelligenceNumeric
            // 
            this.PlayerIntelligenceNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerIntelligenceNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerIntelligenceNumeric.Location = new System.Drawing.Point(217, 282);
            this.PlayerIntelligenceNumeric.Name = "PlayerIntelligenceNumeric";
            this.PlayerIntelligenceNumeric.Size = new System.Drawing.Size(40, 21);
            this.PlayerIntelligenceNumeric.TabIndex = 23;
            this.PlayerIntelligenceNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerIntelligenceNumeric.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // PlayerConstitutionNumeric
            // 
            this.PlayerConstitutionNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerConstitutionNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerConstitutionNumeric.Location = new System.Drawing.Point(217, 254);
            this.PlayerConstitutionNumeric.Name = "PlayerConstitutionNumeric";
            this.PlayerConstitutionNumeric.Size = new System.Drawing.Size(40, 21);
            this.PlayerConstitutionNumeric.TabIndex = 22;
            this.PlayerConstitutionNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerConstitutionNumeric.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // PlayerDexterityNumeric
            // 
            this.PlayerDexterityNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerDexterityNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerDexterityNumeric.Location = new System.Drawing.Point(96, 339);
            this.PlayerDexterityNumeric.Name = "PlayerDexterityNumeric";
            this.PlayerDexterityNumeric.Size = new System.Drawing.Size(40, 21);
            this.PlayerDexterityNumeric.TabIndex = 21;
            this.PlayerDexterityNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerDexterityNumeric.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // PlayerStrengthNumeric
            // 
            this.PlayerStrengthNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerStrengthNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerStrengthNumeric.Location = new System.Drawing.Point(96, 310);
            this.PlayerStrengthNumeric.Name = "PlayerStrengthNumeric";
            this.PlayerStrengthNumeric.Size = new System.Drawing.Size(40, 21);
            this.PlayerStrengthNumeric.TabIndex = 20;
            this.PlayerStrengthNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerStrengthNumeric.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // PlayerMovementNumeric
            // 
            this.PlayerMovementNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerMovementNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerMovementNumeric.Location = new System.Drawing.Point(96, 280);
            this.PlayerMovementNumeric.Name = "PlayerMovementNumeric";
            this.PlayerMovementNumeric.Size = new System.Drawing.Size(40, 21);
            this.PlayerMovementNumeric.TabIndex = 19;
            this.PlayerMovementNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerMovementNumeric.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // PlayerHealthNumeric
            // 
            this.PlayerHealthNumeric.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerHealthNumeric.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerHealthNumeric.Location = new System.Drawing.Point(96, 252);
            this.PlayerHealthNumeric.Name = "PlayerHealthNumeric";
            this.PlayerHealthNumeric.Size = new System.Drawing.Size(40, 21);
            this.PlayerHealthNumeric.TabIndex = 18;
            this.PlayerHealthNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PlayerHealthNumeric.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // PlayerNameTextbox
            // 
            this.PlayerNameTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.PlayerNameTextbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlayerNameTextbox.Font = new System.Drawing.Font("Viner Hand ITC", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerNameTextbox.Location = new System.Drawing.Point(78, 27);
            this.PlayerNameTextbox.Multiline = true;
            this.PlayerNameTextbox.Name = "PlayerNameTextbox";
            this.PlayerNameTextbox.Size = new System.Drawing.Size(133, 20);
            this.PlayerNameTextbox.TabIndex = 9;
            this.PlayerNameTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(125, 11);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 18);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            // 
            // PlayerHealthLabel
            // 
            this.PlayerHealthLabel.AutoSize = true;
            this.PlayerHealthLabel.Location = new System.Drawing.Point(45, 253);
            this.PlayerHealthLabel.Name = "PlayerHealthLabel";
            this.PlayerHealthLabel.Size = new System.Drawing.Size(45, 18);
            this.PlayerHealthLabel.TabIndex = 1;
            this.PlayerHealthLabel.Text = "Health";
            // 
            // PlayerMovementLabel
            // 
            this.PlayerMovementLabel.AutoSize = true;
            this.PlayerMovementLabel.Location = new System.Drawing.Point(37, 281);
            this.PlayerMovementLabel.Name = "PlayerMovementLabel";
            this.PlayerMovementLabel.Size = new System.Drawing.Size(62, 18);
            this.PlayerMovementLabel.TabIndex = 2;
            this.PlayerMovementLabel.Text = "Movement";
            // 
            // PlayerStrengthLabel
            // 
            this.PlayerStrengthLabel.AutoSize = true;
            this.PlayerStrengthLabel.Location = new System.Drawing.Point(40, 311);
            this.PlayerStrengthLabel.Name = "PlayerStrengthLabel";
            this.PlayerStrengthLabel.Size = new System.Drawing.Size(54, 18);
            this.PlayerStrengthLabel.TabIndex = 3;
            this.PlayerStrengthLabel.Text = "Strength";
            // 
            // PlayerConstitutionLabel
            // 
            this.PlayerConstitutionLabel.AutoSize = true;
            this.PlayerConstitutionLabel.Location = new System.Drawing.Point(142, 253);
            this.PlayerConstitutionLabel.Name = "PlayerConstitutionLabel";
            this.PlayerConstitutionLabel.Size = new System.Drawing.Size(75, 18);
            this.PlayerConstitutionLabel.TabIndex = 5;
            this.PlayerConstitutionLabel.Text = "Constitution";
            // 
            // PlayerDexterityLabel
            // 
            this.PlayerDexterityLabel.AutoSize = true;
            this.PlayerDexterityLabel.Location = new System.Drawing.Point(42, 341);
            this.PlayerDexterityLabel.Name = "PlayerDexterityLabel";
            this.PlayerDexterityLabel.Size = new System.Drawing.Size(57, 18);
            this.PlayerDexterityLabel.TabIndex = 4;
            this.PlayerDexterityLabel.Text = "Dexterity";
            // 
            // PlayerCharismaLabel
            // 
            this.PlayerCharismaLabel.AutoSize = true;
            this.PlayerCharismaLabel.Location = new System.Drawing.Point(148, 341);
            this.PlayerCharismaLabel.Name = "PlayerCharismaLabel";
            this.PlayerCharismaLabel.Size = new System.Drawing.Size(59, 18);
            this.PlayerCharismaLabel.TabIndex = 8;
            this.PlayerCharismaLabel.Text = "Charisma";
            // 
            // PlayerIntelligenceLabel
            // 
            this.PlayerIntelligenceLabel.AutoSize = true;
            this.PlayerIntelligenceLabel.Location = new System.Drawing.Point(142, 281);
            this.PlayerIntelligenceLabel.Name = "PlayerIntelligenceLabel";
            this.PlayerIntelligenceLabel.Size = new System.Drawing.Size(68, 18);
            this.PlayerIntelligenceLabel.TabIndex = 6;
            this.PlayerIntelligenceLabel.Text = "Intelligence";
            // 
            // PlayerWisdomLabel
            // 
            this.PlayerWisdomLabel.AutoSize = true;
            this.PlayerWisdomLabel.Location = new System.Drawing.Point(149, 311);
            this.PlayerWisdomLabel.Name = "PlayerWisdomLabel";
            this.PlayerWisdomLabel.Size = new System.Drawing.Size(48, 18);
            this.PlayerWisdomLabel.TabIndex = 7;
            this.PlayerWisdomLabel.Text = "Wisdom";
            // 
            // PlayerListBox
            // 
            this.PlayerListBox.Font = new System.Drawing.Font("Viner Hand ITC", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerListBox.FormattingEnabled = true;
            this.PlayerListBox.ItemHeight = 24;
            this.PlayerListBox.Location = new System.Drawing.Point(21, 428);
            this.PlayerListBox.Name = "PlayerListBox";
            this.PlayerListBox.Size = new System.Drawing.Size(608, 244);
            this.PlayerListBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 725);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 50);
            this.button1.TabIndex = 13;
            this.button1.Text = "Calculate team challenge rating";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // PlayerScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 789);
            this.Controls.Add(this.ChangePlayerAttributes);
            this.Controls.Add(this.AddPlayerButton);
            this.Controls.Add(this.PlayerCreationGroupBox);
            this.Controls.Add(this.PlayerListBox);
            this.Controls.Add(this.button1);
            this.Name = "PlayerScreenForm";
            this.Text = "PlayerScreenForm";
            this.PlayerCreationGroupBox.ResumeLayout(false);
            this.PlayerCreationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerCharismaNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerWisdomNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerIntelligenceNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerConstitutionNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerDexterityNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerStrengthNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerMovementNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerHealthNumeric)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangePlayerAttributes;
        private System.Windows.Forms.Button AddPlayerButton;
        private System.Windows.Forms.GroupBox PlayerCreationGroupBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown PlayerCharismaNumeric;
        private System.Windows.Forms.NumericUpDown PlayerWisdomNumeric;
        private System.Windows.Forms.NumericUpDown PlayerIntelligenceNumeric;
        private System.Windows.Forms.NumericUpDown PlayerConstitutionNumeric;
        private System.Windows.Forms.NumericUpDown PlayerDexterityNumeric;
        private System.Windows.Forms.NumericUpDown PlayerStrengthNumeric;
        private System.Windows.Forms.NumericUpDown PlayerMovementNumeric;
        private System.Windows.Forms.NumericUpDown PlayerHealthNumeric;
        private System.Windows.Forms.TextBox PlayerNameTextbox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PlayerHealthLabel;
        private System.Windows.Forms.Label PlayerMovementLabel;
        private System.Windows.Forms.Label PlayerStrengthLabel;
        private System.Windows.Forms.Label PlayerConstitutionLabel;
        private System.Windows.Forms.Label PlayerDexterityLabel;
        private System.Windows.Forms.Label PlayerCharismaLabel;
        private System.Windows.Forms.Label PlayerIntelligenceLabel;
        private System.Windows.Forms.Label PlayerWisdomLabel;
        private System.Windows.Forms.ListBox PlayerListBox;
        private System.Windows.Forms.Button button1;
    }
}