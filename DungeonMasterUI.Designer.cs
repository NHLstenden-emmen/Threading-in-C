namespace Threading_in_C
{
    partial class DungeonMasterUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DungeonMasterUI));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNPC = new System.Windows.Forms.Button();
            this.btnMonsters = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTurnCounter = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.bntMinimize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelContentScreen = new System.Windows.Forms.Panel();
            this.TitleApplication = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RollTheDice = new System.Windows.Forms.GroupBox();
            this.numericUpDownD8Roll = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxD8Roll = new System.Windows.Forms.PictureBox();
            this.numericUpDownD6Roll = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxD6Roll = new System.Windows.Forms.PictureBox();
            this.numericUpDownD4Roll = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxD4Roll = new System.Windows.Forms.PictureBox();
            this.numericUpDownD10Roll = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxD10Roll = new System.Windows.Forms.PictureBox();
            this.numericUpDownD12Roll = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxD12Roll = new System.Windows.Forms.PictureBox();
            this.numericUpDownD20Roll = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxD20Roll = new System.Windows.Forms.PictureBox();
            this.numericUpDownD100Roll = new System.Windows.Forms.NumericUpDown();
            this.pictureBoxD100Roll = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelContentScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RollTheDice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD8Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD8Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD6Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD6Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD4Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD4Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD10Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD10Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD12Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD12Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD20Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD20Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD100Roll)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD100Roll)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panelMenu.Controls.Add(this.btnSettings);
            this.panelMenu.Controls.Add(this.btnNPC);
            this.panelMenu.Controls.Add(this.btnMonsters);
            this.panelMenu.Controls.Add(this.btnMap);
            this.panelMenu.Controls.Add(this.btnPlayers);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.btnTurnCounter);
            this.panelMenu.Controls.Add(this.btnHome);
            this.panelMenu.Controls.Add(this.bntMinimize);
            this.panelMenu.Controls.Add(this.btnClose);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(724, 30);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelMenu_MouseDown);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(420, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(60, 30);
            this.btnSettings.TabIndex = 27;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnNPC
            // 
            this.btnNPC.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnNPC.FlatAppearance.BorderSize = 0;
            this.btnNPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNPC.Location = new System.Drawing.Point(360, 0);
            this.btnNPC.Name = "btnNPC";
            this.btnNPC.Size = new System.Drawing.Size(60, 30);
            this.btnNPC.TabIndex = 26;
            this.btnNPC.Text = "NPC\'s";
            this.btnNPC.UseVisualStyleBackColor = true;
            this.btnNPC.Click += new System.EventHandler(this.btnNPC_Click);
            // 
            // btnMonsters
            // 
            this.btnMonsters.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMonsters.FlatAppearance.BorderSize = 0;
            this.btnMonsters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonsters.Location = new System.Drawing.Point(300, 0);
            this.btnMonsters.Name = "btnMonsters";
            this.btnMonsters.Size = new System.Drawing.Size(60, 30);
            this.btnMonsters.TabIndex = 25;
            this.btnMonsters.Text = "Monsters";
            this.btnMonsters.UseVisualStyleBackColor = true;
            this.btnMonsters.Click += new System.EventHandler(this.btnMonsters_Click);
            // 
            // btnMap
            // 
            this.btnMap.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnMap.FlatAppearance.BorderSize = 0;
            this.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMap.Location = new System.Drawing.Point(240, 0);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(60, 30);
            this.btnMap.TabIndex = 24;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnPlayers
            // 
            this.btnPlayers.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlayers.FlatAppearance.BorderSize = 0;
            this.btnPlayers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayers.Location = new System.Drawing.Point(180, 0);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(60, 30);
            this.btnPlayers.TabIndex = 23;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(120, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 30);
            this.panel1.TabIndex = 22;
            // 
            // btnTurnCounter
            // 
            this.btnTurnCounter.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnTurnCounter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnCounter.Location = new System.Drawing.Point(60, 0);
            this.btnTurnCounter.Name = "btnTurnCounter";
            this.btnTurnCounter.Size = new System.Drawing.Size(60, 30);
            this.btnTurnCounter.TabIndex = 21;
            this.btnTurnCounter.Text = "0";
            this.btnTurnCounter.UseVisualStyleBackColor = true;
            this.btnTurnCounter.Click += new System.EventHandler(this.btnTurnCounter_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(60, 30);
            this.btnHome.TabIndex = 20;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // bntMinimize
            // 
            this.bntMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bntMinimize.FlatAppearance.BorderSize = 0;
            this.bntMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntMinimize.Location = new System.Drawing.Point(664, 0);
            this.bntMinimize.Name = "bntMinimize";
            this.bntMinimize.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bntMinimize.Size = new System.Drawing.Size(30, 30);
            this.bntMinimize.TabIndex = 10;
            this.bntMinimize.Text = "-";
            this.bntMinimize.UseVisualStyleBackColor = true;
            this.bntMinimize.Click += new System.EventHandler(this.bntMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(694, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panelContentScreen
            // 
            this.panelContentScreen.Controls.Add(this.RollTheDice);
            this.panelContentScreen.Controls.Add(this.TitleApplication);
            this.panelContentScreen.Controls.Add(this.pictureBox1);
            this.panelContentScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentScreen.Location = new System.Drawing.Point(0, 30);
            this.panelContentScreen.Name = "panelContentScreen";
            this.panelContentScreen.Size = new System.Drawing.Size(724, 853);
            this.panelContentScreen.TabIndex = 1;
            // 
            // TitleApplication
            // 
            this.TitleApplication.AutoSize = true;
            this.TitleApplication.Location = new System.Drawing.Point(227, 202);
            this.TitleApplication.Name = "TitleApplication";
            this.TitleApplication.Size = new System.Drawing.Size(205, 13);
            this.TitleApplication.TabIndex = 3;
            this.TitleApplication.Text = "Hier komt de info en title van de applicatie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(180, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // RollTheDice
            // 
            this.RollTheDice.Controls.Add(this.numericUpDownD100Roll);
            this.RollTheDice.Controls.Add(this.pictureBoxD100Roll);
            this.RollTheDice.Controls.Add(this.numericUpDownD20Roll);
            this.RollTheDice.Controls.Add(this.pictureBoxD20Roll);
            this.RollTheDice.Controls.Add(this.numericUpDownD12Roll);
            this.RollTheDice.Controls.Add(this.pictureBoxD12Roll);
            this.RollTheDice.Controls.Add(this.numericUpDownD10Roll);
            this.RollTheDice.Controls.Add(this.pictureBoxD10Roll);
            this.RollTheDice.Controls.Add(this.numericUpDownD8Roll);
            this.RollTheDice.Controls.Add(this.pictureBoxD8Roll);
            this.RollTheDice.Controls.Add(this.numericUpDownD6Roll);
            this.RollTheDice.Controls.Add(this.pictureBoxD6Roll);
            this.RollTheDice.Controls.Add(this.numericUpDownD4Roll);
            this.RollTheDice.Controls.Add(this.pictureBoxD4Roll);
            this.RollTheDice.Location = new System.Drawing.Point(12, 255);
            this.RollTheDice.Name = "RollTheDice";
            this.RollTheDice.Size = new System.Drawing.Size(253, 87);
            this.RollTheDice.TabIndex = 4;
            this.RollTheDice.TabStop = false;
            this.RollTheDice.Text = "groupBox1";
            // 
            // numericUpDownD8Roll
            // 
            this.numericUpDownD8Roll.Location = new System.Drawing.Point(73, 56);
            this.numericUpDownD8Roll.Name = "numericUpDownD8Roll";
            this.numericUpDownD8Roll.Size = new System.Drawing.Size(29, 20);
            this.numericUpDownD8Roll.TabIndex = 5;
            // 
            // pictureBoxD8Roll
            // 
            this.pictureBoxD8Roll.Location = new System.Drawing.Point(73, 19);
            this.pictureBoxD8Roll.Name = "pictureBoxD8Roll";
            this.pictureBoxD8Roll.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxD8Roll.TabIndex = 4;
            this.pictureBoxD8Roll.TabStop = false;
            // 
            // numericUpDownD6Roll
            // 
            this.numericUpDownD6Roll.Location = new System.Drawing.Point(39, 56);
            this.numericUpDownD6Roll.Name = "numericUpDownD6Roll";
            this.numericUpDownD6Roll.Size = new System.Drawing.Size(28, 20);
            this.numericUpDownD6Roll.TabIndex = 3;
            // 
            // pictureBoxD6Roll
            // 
            this.pictureBoxD6Roll.Location = new System.Drawing.Point(39, 19);
            this.pictureBoxD6Roll.Name = "pictureBoxD6Roll";
            this.pictureBoxD6Roll.Size = new System.Drawing.Size(28, 30);
            this.pictureBoxD6Roll.TabIndex = 2;
            this.pictureBoxD6Roll.TabStop = false;
            // 
            // numericUpDownD4Roll
            // 
            this.numericUpDownD4Roll.Location = new System.Drawing.Point(5, 56);
            this.numericUpDownD4Roll.Name = "numericUpDownD4Roll";
            this.numericUpDownD4Roll.Size = new System.Drawing.Size(28, 20);
            this.numericUpDownD4Roll.TabIndex = 1;
            // 
            // pictureBoxD4Roll
            // 
            this.pictureBoxD4Roll.Location = new System.Drawing.Point(5, 19);
            this.pictureBoxD4Roll.Name = "pictureBoxD4Roll";
            this.pictureBoxD4Roll.Size = new System.Drawing.Size(28, 30);
            this.pictureBoxD4Roll.TabIndex = 0;
            this.pictureBoxD4Roll.TabStop = false;
            // 
            // numericUpDownD10Roll
            // 
            this.numericUpDownD10Roll.Location = new System.Drawing.Point(108, 56);
            this.numericUpDownD10Roll.Name = "numericUpDownD10Roll";
            this.numericUpDownD10Roll.Size = new System.Drawing.Size(29, 20);
            this.numericUpDownD10Roll.TabIndex = 7;
            // 
            // pictureBoxD10Roll
            // 
            this.pictureBoxD10Roll.Location = new System.Drawing.Point(108, 19);
            this.pictureBoxD10Roll.Name = "pictureBoxD10Roll";
            this.pictureBoxD10Roll.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxD10Roll.TabIndex = 6;
            this.pictureBoxD10Roll.TabStop = false;
            // 
            // numericUpDownD12Roll
            // 
            this.numericUpDownD12Roll.Location = new System.Drawing.Point(143, 56);
            this.numericUpDownD12Roll.Name = "numericUpDownD12Roll";
            this.numericUpDownD12Roll.Size = new System.Drawing.Size(29, 20);
            this.numericUpDownD12Roll.TabIndex = 9;
            // 
            // pictureBoxD12Roll
            // 
            this.pictureBoxD12Roll.Location = new System.Drawing.Point(143, 19);
            this.pictureBoxD12Roll.Name = "pictureBoxD12Roll";
            this.pictureBoxD12Roll.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxD12Roll.TabIndex = 8;
            this.pictureBoxD12Roll.TabStop = false;
            // 
            // numericUpDownD20Roll
            // 
            this.numericUpDownD20Roll.Location = new System.Drawing.Point(178, 56);
            this.numericUpDownD20Roll.Name = "numericUpDownD20Roll";
            this.numericUpDownD20Roll.Size = new System.Drawing.Size(29, 20);
            this.numericUpDownD20Roll.TabIndex = 11;
            // 
            // pictureBoxD20Roll
            // 
            this.pictureBoxD20Roll.Location = new System.Drawing.Point(178, 19);
            this.pictureBoxD20Roll.Name = "pictureBoxD20Roll";
            this.pictureBoxD20Roll.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxD20Roll.TabIndex = 10;
            this.pictureBoxD20Roll.TabStop = false;
            // 
            // numericUpDownD100Roll
            // 
            this.numericUpDownD100Roll.Location = new System.Drawing.Point(217, 56);
            this.numericUpDownD100Roll.Name = "numericUpDownD100Roll";
            this.numericUpDownD100Roll.Size = new System.Drawing.Size(29, 20);
            this.numericUpDownD100Roll.TabIndex = 13;
            // 
            // pictureBoxD100Roll
            // 
            this.pictureBoxD100Roll.Location = new System.Drawing.Point(217, 19);
            this.pictureBoxD100Roll.Name = "pictureBoxD100Roll";
            this.pictureBoxD100Roll.Size = new System.Drawing.Size(29, 30);
            this.pictureBoxD100Roll.TabIndex = 12;
            this.pictureBoxD100Roll.TabStop = false;
            // 
            // DungeonMasterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 883);
            this.Controls.Add(this.panelContentScreen);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(724, 2000);
            this.MinimumSize = new System.Drawing.Size(724, 883);
            this.Name = "DungeonMasterUI";
            this.Text = "DungeonMasterUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelContentScreen.ResumeLayout(false);
            this.panelContentScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RollTheDice.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD8Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD8Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD6Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD6Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD4Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD4Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD10Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD10Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD12Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD12Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD20Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD20Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownD100Roll)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD100Roll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelContentScreen;
        private System.Windows.Forms.Button bntMinimize;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label TitleApplication;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNPC;
        private System.Windows.Forms.Button btnMonsters;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btnTurnCounter;
        private System.Windows.Forms.GroupBox RollTheDice;
        private System.Windows.Forms.NumericUpDown numericUpDownD100Roll;
        private System.Windows.Forms.PictureBox pictureBoxD100Roll;
        private System.Windows.Forms.NumericUpDown numericUpDownD20Roll;
        private System.Windows.Forms.PictureBox pictureBoxD20Roll;
        private System.Windows.Forms.NumericUpDown numericUpDownD12Roll;
        private System.Windows.Forms.PictureBox pictureBoxD12Roll;
        private System.Windows.Forms.NumericUpDown numericUpDownD10Roll;
        private System.Windows.Forms.PictureBox pictureBoxD10Roll;
        private System.Windows.Forms.NumericUpDown numericUpDownD8Roll;
        private System.Windows.Forms.PictureBox pictureBoxD8Roll;
        private System.Windows.Forms.NumericUpDown numericUpDownD6Roll;
        private System.Windows.Forms.PictureBox pictureBoxD6Roll;
        private System.Windows.Forms.NumericUpDown numericUpDownD4Roll;
        private System.Windows.Forms.PictureBox pictureBoxD4Roll;
    }
}
