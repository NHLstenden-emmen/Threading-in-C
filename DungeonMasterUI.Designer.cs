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
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNPC = new System.Windows.Forms.Button();
            this.btnMonsters = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnPlayers = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelContentScreen = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.panelMenu.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(708, 30);
            this.panelMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Location = new System.Drawing.Point(420, 0);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(60, 30);
            this.btnSettings.TabIndex = 9;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
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
            this.btnNPC.TabIndex = 8;
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
            this.btnMonsters.TabIndex = 7;
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
            this.btnMap.TabIndex = 6;
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
            this.btnPlayers.TabIndex = 5;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(180, 30);
            this.panelLogo.TabIndex = 4;
            // 
            // panelContentScreen
            // 
            this.panelContentScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContentScreen.Location = new System.Drawing.Point(0, 30);
            this.panelContentScreen.Name = "panelContentScreen";
            this.panelContentScreen.Size = new System.Drawing.Size(708, 814);
            this.panelContentScreen.TabIndex = 1;
            // 
            // DungeonMasterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 844);
            this.Controls.Add(this.panelContentScreen);
            this.Controls.Add(this.panelMenu);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(724, 885);
            this.MinimumSize = new System.Drawing.Size(724, 883);
            this.Name = "DungeonMasterUI";
            this.Text = "DungeonMasterUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnNPC;
        private System.Windows.Forms.Button btnMonsters;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Panel panelContentScreen;
    }
}
