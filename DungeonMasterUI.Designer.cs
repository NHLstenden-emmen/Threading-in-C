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
            this.menuBar = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GenerateMapsButton = new System.Windows.Forms.TabPage();
            this.DeleteMap = new System.Windows.Forms.Button();
            this.SavedMapsBox = new System.Windows.Forms.RichTextBox();
            this.MapExampleThree = new System.Windows.Forms.RichTextBox();
            this.MapExampleTwo = new System.Windows.Forms.RichTextBox();
            this.MapExampleOne = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AmountOfMaps = new System.Windows.Forms.NumericUpDown();
            this.GenerateEnemies = new System.Windows.Forms.CheckBox();
            this.GridSizeTextBox = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GenerateLootOnMapCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DeleteEnemyButton = new System.Windows.Forms.Button();
            this.SavedEnemyBox = new System.Windows.Forms.RichTextBox();
            this.EnemyExampleSix = new System.Windows.Forms.RichTextBox();
            this.EnemyExampleFive = new System.Windows.Forms.RichTextBox();
            this.EnemyExampleFour = new System.Windows.Forms.RichTextBox();
            this.EnemyExampleThree = new System.Windows.Forms.RichTextBox();
            this.EnemyExampleTwo = new System.Windows.Forms.RichTextBox();
            this.EnemyExample = new System.Windows.Forms.RichTextBox();
            this.GenerateMonsterButton = new System.Windows.Forms.Button();
            this.MonsterAmount = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.DifficultyText = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.NPCExampleSix = new System.Windows.Forms.RichTextBox();
            this.NPCExampleFive = new System.Windows.Forms.RichTextBox();
            this.NPCExampleFour = new System.Windows.Forms.RichTextBox();
            this.NPCExampleThree = new System.Windows.Forms.RichTextBox();
            this.NPCExampleTwo = new System.Windows.Forms.RichTextBox();
            this.NPCExampleOne = new System.Windows.Forms.RichTextBox();
            this.DeleteNPC = new System.Windows.Forms.Button();
            this.AmountOfNPCs = new System.Windows.Forms.NumericUpDown();
            this.GenerateNPCButton = new System.Windows.Forms.Button();
            this.SavedNPCList = new System.Windows.Forms.RichTextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SavedGameBox = new System.Windows.Forms.RichTextBox();
            this.ImportGameButton = new System.Windows.Forms.Button();
            this.ExportGameButton = new System.Windows.Forms.Button();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.PlayerCreationGroupBox = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PlayerHealthLabel = new System.Windows.Forms.Label();
            this.PlayerMovementLabel = new System.Windows.Forms.Label();
            this.PlayerStrengthLabel = new System.Windows.Forms.Label();
            this.PlayerDexterityLabel = new System.Windows.Forms.Label();
            this.PlayerConstitutionLabel = new System.Windows.Forms.Label();
            this.PlayerIntelligenceLabel = new System.Windows.Forms.Label();
            this.PlayerWisdomLabel = new System.Windows.Forms.Label();
            this.PlayerCharismaLabel = new System.Windows.Forms.Label();
            this.PlayerNameTextbox = new System.Windows.Forms.TextBox();
            this.PlayerHealthTextbox = new System.Windows.Forms.TextBox();
            this.PlayerMovementTextbox = new System.Windows.Forms.TextBox();
            this.PlayerStrengthTextbox = new System.Windows.Forms.TextBox();
            this.PlayerDexterityTextbox = new System.Windows.Forms.TextBox();
            this.PlayerConstitutionTextbox = new System.Windows.Forms.TextBox();
            this.PlayerIntelligenceTextbox = new System.Windows.Forms.TextBox();
            this.PlayerWisdomTextbox = new System.Windows.Forms.TextBox();
            this.PlayerCharismaTextbox = new System.Windows.Forms.TextBox();
            this.menuBar.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GenerateMapsButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfMaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfNPCs)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.PlayerCreationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Controls.Add(this.tabPage1);
            this.menuBar.Controls.Add(this.GenerateMapsButton);
            this.menuBar.Controls.Add(this.tabPage3);
            this.menuBar.Controls.Add(this.tabPage4);
            this.menuBar.Controls.Add(this.tabPage5);
            this.menuBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Margin = new System.Windows.Forms.Padding(2);
            this.menuBar.Name = "menuBar";
            this.menuBar.SelectedIndex = 0;
            this.menuBar.Size = new System.Drawing.Size(708, 844);
            this.menuBar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.PlayerCreationGroupBox);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(700, 818);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Threading_in_C.Properties.Resources.magicitemcards_template_front_poker;
            this.pictureBox1.Location = new System.Drawing.Point(47, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 751);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Calculate team challenge rating";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // GenerateMapsButton
            // 
            this.GenerateMapsButton.Controls.Add(this.DeleteMap);
            this.GenerateMapsButton.Controls.Add(this.SavedMapsBox);
            this.GenerateMapsButton.Controls.Add(this.MapExampleThree);
            this.GenerateMapsButton.Controls.Add(this.MapExampleTwo);
            this.GenerateMapsButton.Controls.Add(this.MapExampleOne);
            this.GenerateMapsButton.Controls.Add(this.button2);
            this.GenerateMapsButton.Controls.Add(this.AmountOfMaps);
            this.GenerateMapsButton.Controls.Add(this.GenerateEnemies);
            this.GenerateMapsButton.Controls.Add(this.GridSizeTextBox);
            this.GenerateMapsButton.Controls.Add(this.numericUpDown1);
            this.GenerateMapsButton.Controls.Add(this.GenerateLootOnMapCheckBox);
            this.GenerateMapsButton.Location = new System.Drawing.Point(4, 22);
            this.GenerateMapsButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateMapsButton.Name = "GenerateMapsButton";
            this.GenerateMapsButton.Padding = new System.Windows.Forms.Padding(2);
            this.GenerateMapsButton.Size = new System.Drawing.Size(700, 818);
            this.GenerateMapsButton.TabIndex = 1;
            this.GenerateMapsButton.Text = "Map";
            this.GenerateMapsButton.UseVisualStyleBackColor = true;
            // 
            // DeleteMap
            // 
            this.DeleteMap.Location = new System.Drawing.Point(278, 674);
            this.DeleteMap.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteMap.Name = "DeleteMap";
            this.DeleteMap.Size = new System.Drawing.Size(136, 58);
            this.DeleteMap.TabIndex = 11;
            this.DeleteMap.Text = "DeleteMap";
            this.DeleteMap.UseVisualStyleBackColor = true;
            // 
            // SavedMapsBox
            // 
            this.SavedMapsBox.Location = new System.Drawing.Point(23, 436);
            this.SavedMapsBox.Margin = new System.Windows.Forms.Padding(2);
            this.SavedMapsBox.Name = "SavedMapsBox";
            this.SavedMapsBox.Size = new System.Drawing.Size(647, 191);
            this.SavedMapsBox.TabIndex = 10;
            this.SavedMapsBox.Text = "Saved Maps Example";
            this.SavedMapsBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged_1);
            // 
            // MapExampleThree
            // 
            this.MapExampleThree.Location = new System.Drawing.Point(478, 141);
            this.MapExampleThree.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleThree.Name = "MapExampleThree";
            this.MapExampleThree.Size = new System.Drawing.Size(192, 191);
            this.MapExampleThree.TabIndex = 9;
            this.MapExampleThree.Text = "Map Example Three";
            // 
            // MapExampleTwo
            // 
            this.MapExampleTwo.Location = new System.Drawing.Point(247, 141);
            this.MapExampleTwo.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleTwo.Name = "MapExampleTwo";
            this.MapExampleTwo.Size = new System.Drawing.Size(192, 191);
            this.MapExampleTwo.TabIndex = 8;
            this.MapExampleTwo.Text = "Map Example Two";
            // 
            // MapExampleOne
            // 
            this.MapExampleOne.Location = new System.Drawing.Point(23, 141);
            this.MapExampleOne.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleOne.Name = "MapExampleOne";
            this.MapExampleOne.Size = new System.Drawing.Size(192, 191);
            this.MapExampleOne.TabIndex = 7;
            this.MapExampleOne.Text = "Map Example One";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(254, 89);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 19);
            this.button2.TabIndex = 6;
            this.button2.Text = "Generate Maps";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AmountOfMaps
            // 
            this.AmountOfMaps.Location = new System.Drawing.Point(344, 89);
            this.AmountOfMaps.Margin = new System.Windows.Forms.Padding(2);
            this.AmountOfMaps.Name = "AmountOfMaps";
            this.AmountOfMaps.Size = new System.Drawing.Size(90, 20);
            this.AmountOfMaps.TabIndex = 4;
            this.AmountOfMaps.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // GenerateEnemies
            // 
            this.GenerateEnemies.AutoSize = true;
            this.GenerateEnemies.Location = new System.Drawing.Point(563, 25);
            this.GenerateEnemies.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateEnemies.Name = "GenerateEnemies";
            this.GenerateEnemies.Size = new System.Drawing.Size(113, 17);
            this.GenerateEnemies.TabIndex = 3;
            this.GenerateEnemies.Text = "Generate Enemies";
            this.GenerateEnemies.UseVisualStyleBackColor = true;
            // 
            // GridSizeTextBox
            // 
            this.GridSizeTextBox.Location = new System.Drawing.Point(262, 25);
            this.GridSizeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GridSizeTextBox.Name = "GridSizeTextBox";
            this.GridSizeTextBox.ReadOnly = true;
            this.GridSizeTextBox.Size = new System.Drawing.Size(76, 20);
            this.GridSizeTextBox.TabIndex = 2;
            this.GridSizeTextBox.Text = "Grid Size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(337, 25);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 1;
            // 
            // GenerateLootOnMapCheckBox
            // 
            this.GenerateLootOnMapCheckBox.AutoSize = true;
            this.GenerateLootOnMapCheckBox.Location = new System.Drawing.Point(23, 25);
            this.GenerateLootOnMapCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateLootOnMapCheckBox.Name = "GenerateLootOnMapCheckBox";
            this.GenerateLootOnMapCheckBox.Size = new System.Drawing.Size(93, 17);
            this.GenerateLootOnMapCheckBox.TabIndex = 0;
            this.GenerateLootOnMapCheckBox.Text = "Generate loot ";
            this.GenerateLootOnMapCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeleteEnemyButton);
            this.tabPage3.Controls.Add(this.SavedEnemyBox);
            this.tabPage3.Controls.Add(this.EnemyExampleSix);
            this.tabPage3.Controls.Add(this.EnemyExampleFive);
            this.tabPage3.Controls.Add(this.EnemyExampleFour);
            this.tabPage3.Controls.Add(this.EnemyExampleThree);
            this.tabPage3.Controls.Add(this.EnemyExampleTwo);
            this.tabPage3.Controls.Add(this.EnemyExample);
            this.tabPage3.Controls.Add(this.GenerateMonsterButton);
            this.tabPage3.Controls.Add(this.MonsterAmount);
            this.tabPage3.Controls.Add(this.numericUpDown2);
            this.tabPage3.Controls.Add(this.DifficultyText);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(700, 818);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Monsters";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DeleteEnemyButton
            // 
            this.DeleteEnemyButton.Location = new System.Drawing.Point(91, 631);
            this.DeleteEnemyButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteEnemyButton.Name = "DeleteEnemyButton";
            this.DeleteEnemyButton.Size = new System.Drawing.Size(165, 59);
            this.DeleteEnemyButton.TabIndex = 12;
            this.DeleteEnemyButton.Text = "Delete Enemy";
            this.DeleteEnemyButton.UseVisualStyleBackColor = true;
            this.DeleteEnemyButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // SavedEnemyBox
            // 
            this.SavedEnemyBox.Location = new System.Drawing.Point(368, 13);
            this.SavedEnemyBox.Margin = new System.Windows.Forms.Padding(2);
            this.SavedEnemyBox.Name = "SavedEnemyBox";
            this.SavedEnemyBox.Size = new System.Drawing.Size(302, 768);
            this.SavedEnemyBox.TabIndex = 11;
            this.SavedEnemyBox.Text = "Saved Enemies appear here";
            // 
            // EnemyExampleSix
            // 
            this.EnemyExampleSix.Location = new System.Drawing.Point(218, 424);
            this.EnemyExampleSix.Margin = new System.Windows.Forms.Padding(2);
            this.EnemyExampleSix.Name = "EnemyExampleSix";
            this.EnemyExampleSix.Size = new System.Drawing.Size(115, 127);
            this.EnemyExampleSix.TabIndex = 10;
            this.EnemyExampleSix.Text = "Enemy Example 6";
            // 
            // EnemyExampleFive
            // 
            this.EnemyExampleFive.Location = new System.Drawing.Point(218, 259);
            this.EnemyExampleFive.Margin = new System.Windows.Forms.Padding(2);
            this.EnemyExampleFive.Name = "EnemyExampleFive";
            this.EnemyExampleFive.Size = new System.Drawing.Size(115, 127);
            this.EnemyExampleFive.TabIndex = 9;
            this.EnemyExampleFive.Text = "Enemy Example 5";
            // 
            // EnemyExampleFour
            // 
            this.EnemyExampleFour.Location = new System.Drawing.Point(218, 101);
            this.EnemyExampleFour.Margin = new System.Windows.Forms.Padding(2);
            this.EnemyExampleFour.Name = "EnemyExampleFour";
            this.EnemyExampleFour.Size = new System.Drawing.Size(115, 127);
            this.EnemyExampleFour.TabIndex = 8;
            this.EnemyExampleFour.Text = "Enemy Example 4";
            // 
            // EnemyExampleThree
            // 
            this.EnemyExampleThree.Location = new System.Drawing.Point(44, 424);
            this.EnemyExampleThree.Margin = new System.Windows.Forms.Padding(2);
            this.EnemyExampleThree.Name = "EnemyExampleThree";
            this.EnemyExampleThree.Size = new System.Drawing.Size(115, 127);
            this.EnemyExampleThree.TabIndex = 7;
            this.EnemyExampleThree.Text = "Enemy Example 3";
            // 
            // EnemyExampleTwo
            // 
            this.EnemyExampleTwo.Location = new System.Drawing.Point(44, 259);
            this.EnemyExampleTwo.Margin = new System.Windows.Forms.Padding(2);
            this.EnemyExampleTwo.Name = "EnemyExampleTwo";
            this.EnemyExampleTwo.Size = new System.Drawing.Size(115, 127);
            this.EnemyExampleTwo.TabIndex = 6;
            this.EnemyExampleTwo.Text = "EnemyExample 2";
            // 
            // EnemyExample
            // 
            this.EnemyExample.Location = new System.Drawing.Point(44, 101);
            this.EnemyExample.Margin = new System.Windows.Forms.Padding(2);
            this.EnemyExample.Name = "EnemyExample";
            this.EnemyExample.Size = new System.Drawing.Size(115, 127);
            this.EnemyExample.TabIndex = 5;
            this.EnemyExample.Text = "EnemyExample";
            // 
            // GenerateMonsterButton
            // 
            this.GenerateMonsterButton.Location = new System.Drawing.Point(173, 27);
            this.GenerateMonsterButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateMonsterButton.Name = "GenerateMonsterButton";
            this.GenerateMonsterButton.Size = new System.Drawing.Size(104, 19);
            this.GenerateMonsterButton.TabIndex = 4;
            this.GenerateMonsterButton.Text = "Generate Monsters";
            this.GenerateMonsterButton.UseVisualStyleBackColor = true;
            // 
            // MonsterAmount
            // 
            this.MonsterAmount.Location = new System.Drawing.Point(276, 27);
            this.MonsterAmount.Margin = new System.Windows.Forms.Padding(2);
            this.MonsterAmount.Name = "MonsterAmount";
            this.MonsterAmount.Size = new System.Drawing.Size(33, 20);
            this.MonsterAmount.TabIndex = 3;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(91, 28);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(33, 20);
            this.numericUpDown2.TabIndex = 1;
            // 
            // DifficultyText
            // 
            this.DifficultyText.Enabled = false;
            this.DifficultyText.Location = new System.Drawing.Point(44, 28);
            this.DifficultyText.Margin = new System.Windows.Forms.Padding(2);
            this.DifficultyText.Name = "DifficultyText";
            this.DifficultyText.Size = new System.Drawing.Size(48, 20);
            this.DifficultyText.TabIndex = 0;
            this.DifficultyText.Text = "Difficulty";
            this.DifficultyText.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.NPCExampleSix);
            this.tabPage4.Controls.Add(this.NPCExampleFive);
            this.tabPage4.Controls.Add(this.NPCExampleFour);
            this.tabPage4.Controls.Add(this.NPCExampleThree);
            this.tabPage4.Controls.Add(this.NPCExampleTwo);
            this.tabPage4.Controls.Add(this.NPCExampleOne);
            this.tabPage4.Controls.Add(this.DeleteNPC);
            this.tabPage4.Controls.Add(this.AmountOfNPCs);
            this.tabPage4.Controls.Add(this.GenerateNPCButton);
            this.tabPage4.Controls.Add(this.SavedNPCList);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage4.Size = new System.Drawing.Size(700, 818);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "NPC\'s";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // NPCExampleSix
            // 
            this.NPCExampleSix.Location = new System.Drawing.Point(203, 417);
            this.NPCExampleSix.Margin = new System.Windows.Forms.Padding(2);
            this.NPCExampleSix.Name = "NPCExampleSix";
            this.NPCExampleSix.Size = new System.Drawing.Size(116, 123);
            this.NPCExampleSix.TabIndex = 9;
            this.NPCExampleSix.Text = "NPC Example";
            this.NPCExampleSix.TextChanged += new System.EventHandler(this.richTextBox4_TextChanged);
            // 
            // NPCExampleFive
            // 
            this.NPCExampleFive.Location = new System.Drawing.Point(203, 258);
            this.NPCExampleFive.Margin = new System.Windows.Forms.Padding(2);
            this.NPCExampleFive.Name = "NPCExampleFive";
            this.NPCExampleFive.Size = new System.Drawing.Size(116, 123);
            this.NPCExampleFive.TabIndex = 8;
            this.NPCExampleFive.Text = "NPC Example";
            // 
            // NPCExampleFour
            // 
            this.NPCExampleFour.Location = new System.Drawing.Point(203, 99);
            this.NPCExampleFour.Margin = new System.Windows.Forms.Padding(2);
            this.NPCExampleFour.Name = "NPCExampleFour";
            this.NPCExampleFour.Size = new System.Drawing.Size(116, 123);
            this.NPCExampleFour.TabIndex = 7;
            this.NPCExampleFour.Text = "NPC Example";
            // 
            // NPCExampleThree
            // 
            this.NPCExampleThree.Location = new System.Drawing.Point(45, 417);
            this.NPCExampleThree.Margin = new System.Windows.Forms.Padding(2);
            this.NPCExampleThree.Name = "NPCExampleThree";
            this.NPCExampleThree.Size = new System.Drawing.Size(116, 123);
            this.NPCExampleThree.TabIndex = 6;
            this.NPCExampleThree.Text = "NPC Example";
            // 
            // NPCExampleTwo
            // 
            this.NPCExampleTwo.Location = new System.Drawing.Point(45, 258);
            this.NPCExampleTwo.Margin = new System.Windows.Forms.Padding(2);
            this.NPCExampleTwo.Name = "NPCExampleTwo";
            this.NPCExampleTwo.Size = new System.Drawing.Size(116, 123);
            this.NPCExampleTwo.TabIndex = 5;
            this.NPCExampleTwo.Text = "NPC Example";
            // 
            // NPCExampleOne
            // 
            this.NPCExampleOne.Location = new System.Drawing.Point(45, 99);
            this.NPCExampleOne.Margin = new System.Windows.Forms.Padding(2);
            this.NPCExampleOne.Name = "NPCExampleOne";
            this.NPCExampleOne.Size = new System.Drawing.Size(116, 123);
            this.NPCExampleOne.TabIndex = 4;
            this.NPCExampleOne.Text = "NPC Example";
            // 
            // DeleteNPC
            // 
            this.DeleteNPC.Location = new System.Drawing.Point(100, 599);
            this.DeleteNPC.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteNPC.Name = "DeleteNPC";
            this.DeleteNPC.Size = new System.Drawing.Size(153, 71);
            this.DeleteNPC.TabIndex = 3;
            this.DeleteNPC.Text = "Delete NPC";
            this.DeleteNPC.UseVisualStyleBackColor = true;
            // 
            // AmountOfNPCs
            // 
            this.AmountOfNPCs.Location = new System.Drawing.Point(130, 50);
            this.AmountOfNPCs.Margin = new System.Windows.Forms.Padding(2);
            this.AmountOfNPCs.Name = "AmountOfNPCs";
            this.AmountOfNPCs.Size = new System.Drawing.Size(30, 20);
            this.AmountOfNPCs.TabIndex = 2;
            // 
            // GenerateNPCButton
            // 
            this.GenerateNPCButton.Location = new System.Drawing.Point(45, 50);
            this.GenerateNPCButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateNPCButton.Name = "GenerateNPCButton";
            this.GenerateNPCButton.Size = new System.Drawing.Size(86, 19);
            this.GenerateNPCButton.TabIndex = 1;
            this.GenerateNPCButton.Text = "Generate NPC\'s";
            this.GenerateNPCButton.UseVisualStyleBackColor = true;
            // 
            // SavedNPCList
            // 
            this.SavedNPCList.Location = new System.Drawing.Point(367, 50);
            this.SavedNPCList.Margin = new System.Windows.Forms.Padding(2);
            this.SavedNPCList.Name = "SavedNPCList";
            this.SavedNPCList.Size = new System.Drawing.Size(297, 730);
            this.SavedNPCList.TabIndex = 0;
            this.SavedNPCList.Text = "Saved NPC\'s Appear here";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.textBox1);
            this.tabPage5.Controls.Add(this.SavedGameBox);
            this.tabPage5.Controls.Add(this.ImportGameButton);
            this.tabPage5.Controls.Add(this.ExportGameButton);
            this.tabPage5.Controls.Add(this.SaveGameButton);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage5.Size = new System.Drawing.Size(700, 818);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Settings";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(171, 754);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "Last saved on ... ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SavedGameBox
            // 
            this.SavedGameBox.Location = new System.Drawing.Point(335, 24);
            this.SavedGameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SavedGameBox.Name = "SavedGameBox";
            this.SavedGameBox.Size = new System.Drawing.Size(321, 400);
            this.SavedGameBox.TabIndex = 3;
            this.SavedGameBox.Text = "Save games appear here";
            // 
            // ImportGameButton
            // 
            this.ImportGameButton.Location = new System.Drawing.Point(27, 206);
            this.ImportGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImportGameButton.Name = "ImportGameButton";
            this.ImportGameButton.Size = new System.Drawing.Size(182, 66);
            this.ImportGameButton.TabIndex = 2;
            this.ImportGameButton.Text = "Import Game";
            this.ImportGameButton.UseVisualStyleBackColor = true;
            // 
            // ExportGameButton
            // 
            this.ExportGameButton.Location = new System.Drawing.Point(27, 115);
            this.ExportGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExportGameButton.Name = "ExportGameButton";
            this.ExportGameButton.Size = new System.Drawing.Size(182, 66);
            this.ExportGameButton.TabIndex = 1;
            this.ExportGameButton.Text = "Export Game";
            this.ExportGameButton.UseVisualStyleBackColor = true;
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Location = new System.Drawing.Point(27, 24);
            this.SaveGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(182, 66);
            this.SaveGameButton.TabIndex = 0;
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(557, 18);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 8;
            // 
            // PlayerCreationGroupBox
            // 
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerCharismaTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerWisdomTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerIntelligenceTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerConstitutionTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerDexterityTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerStrengthTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerMovementTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerHealthTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerNameTextbox);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerCharismaLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerWisdomLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerIntelligenceLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerConstitutionLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerDexterityLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerStrengthLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerMovementLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.PlayerHealthLabel);
            this.PlayerCreationGroupBox.Controls.Add(this.NameLabel);
            this.PlayerCreationGroupBox.Location = new System.Drawing.Point(370, 264);
            this.PlayerCreationGroupBox.Name = "PlayerCreationGroupBox";
            this.PlayerCreationGroupBox.Size = new System.Drawing.Size(200, 167);
            this.PlayerCreationGroupBox.TabIndex = 9;
            this.PlayerCreationGroupBox.TabStop = false;
            this.PlayerCreationGroupBox.Text = "PLayer Creation";
            this.PlayerCreationGroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(6, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(35, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Name";
            this.NameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerHealthLabel
            // 
            this.PlayerHealthLabel.AutoSize = true;
            this.PlayerHealthLabel.Location = new System.Drawing.Point(7, 33);
            this.PlayerHealthLabel.Name = "PlayerHealthLabel";
            this.PlayerHealthLabel.Size = new System.Drawing.Size(38, 13);
            this.PlayerHealthLabel.TabIndex = 1;
            this.PlayerHealthLabel.Text = "Health";
            // 
            // PlayerMovementLabel
            // 
            this.PlayerMovementLabel.AutoSize = true;
            this.PlayerMovementLabel.Location = new System.Drawing.Point(7, 50);
            this.PlayerMovementLabel.Name = "PlayerMovementLabel";
            this.PlayerMovementLabel.Size = new System.Drawing.Size(57, 13);
            this.PlayerMovementLabel.TabIndex = 2;
            this.PlayerMovementLabel.Text = "Movement";
            // 
            // PlayerStrengthLabel
            // 
            this.PlayerStrengthLabel.AutoSize = true;
            this.PlayerStrengthLabel.Location = new System.Drawing.Point(7, 67);
            this.PlayerStrengthLabel.Name = "PlayerStrengthLabel";
            this.PlayerStrengthLabel.Size = new System.Drawing.Size(47, 13);
            this.PlayerStrengthLabel.TabIndex = 3;
            this.PlayerStrengthLabel.Text = "Strength";
            // 
            // PlayerDexterityLabel
            // 
            this.PlayerDexterityLabel.AutoSize = true;
            this.PlayerDexterityLabel.Location = new System.Drawing.Point(7, 84);
            this.PlayerDexterityLabel.Name = "PlayerDexterityLabel";
            this.PlayerDexterityLabel.Size = new System.Drawing.Size(48, 13);
            this.PlayerDexterityLabel.TabIndex = 4;
            this.PlayerDexterityLabel.Text = "Dexterity";
            // 
            // PlayerConstitutionLabel
            // 
            this.PlayerConstitutionLabel.AutoSize = true;
            this.PlayerConstitutionLabel.Location = new System.Drawing.Point(7, 101);
            this.PlayerConstitutionLabel.Name = "PlayerConstitutionLabel";
            this.PlayerConstitutionLabel.Size = new System.Drawing.Size(62, 13);
            this.PlayerConstitutionLabel.TabIndex = 5;
            this.PlayerConstitutionLabel.Text = "Constitution";
            // 
            // PlayerIntelligenceLabel
            // 
            this.PlayerIntelligenceLabel.AutoSize = true;
            this.PlayerIntelligenceLabel.Location = new System.Drawing.Point(7, 118);
            this.PlayerIntelligenceLabel.Name = "PlayerIntelligenceLabel";
            this.PlayerIntelligenceLabel.Size = new System.Drawing.Size(61, 13);
            this.PlayerIntelligenceLabel.TabIndex = 6;
            this.PlayerIntelligenceLabel.Text = "Intelligence";
            // 
            // PlayerWisdomLabel
            // 
            this.PlayerWisdomLabel.AutoSize = true;
            this.PlayerWisdomLabel.Location = new System.Drawing.Point(7, 135);
            this.PlayerWisdomLabel.Name = "PlayerWisdomLabel";
            this.PlayerWisdomLabel.Size = new System.Drawing.Size(45, 13);
            this.PlayerWisdomLabel.TabIndex = 7;
            this.PlayerWisdomLabel.Text = "Wisdom";
            // 
            // PlayerCharismaLabel
            // 
            this.PlayerCharismaLabel.AutoSize = true;
            this.PlayerCharismaLabel.Location = new System.Drawing.Point(7, 152);
            this.PlayerCharismaLabel.Name = "PlayerCharismaLabel";
            this.PlayerCharismaLabel.Size = new System.Drawing.Size(50, 13);
            this.PlayerCharismaLabel.TabIndex = 8;
            this.PlayerCharismaLabel.Text = "Charisma";
            // 
            // PlayerNameTextbox
            // 
            this.PlayerNameTextbox.Location = new System.Drawing.Point(99, 8);
            this.PlayerNameTextbox.Name = "PlayerNameTextbox";
            this.PlayerNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerNameTextbox.TabIndex = 9;
            // 
            // PlayerHealthTextbox
            // 
            this.PlayerHealthTextbox.Location = new System.Drawing.Point(99, 26);
            this.PlayerHealthTextbox.Name = "PlayerHealthTextbox";
            this.PlayerHealthTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerHealthTextbox.TabIndex = 10;
            // 
            // PlayerMovementTextbox
            // 
            this.PlayerMovementTextbox.Location = new System.Drawing.Point(99, 43);
            this.PlayerMovementTextbox.Name = "PlayerMovementTextbox";
            this.PlayerMovementTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerMovementTextbox.TabIndex = 11;
            // 
            // PlayerStrengthTextbox
            // 
            this.PlayerStrengthTextbox.Location = new System.Drawing.Point(99, 60);
            this.PlayerStrengthTextbox.Name = "PlayerStrengthTextbox";
            this.PlayerStrengthTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerStrengthTextbox.TabIndex = 12;
            // 
            // PlayerDexterityTextbox
            // 
            this.PlayerDexterityTextbox.Location = new System.Drawing.Point(99, 77);
            this.PlayerDexterityTextbox.Name = "PlayerDexterityTextbox";
            this.PlayerDexterityTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerDexterityTextbox.TabIndex = 13;
            // 
            // PlayerConstitutionTextbox
            // 
            this.PlayerConstitutionTextbox.Location = new System.Drawing.Point(99, 94);
            this.PlayerConstitutionTextbox.Name = "PlayerConstitutionTextbox";
            this.PlayerConstitutionTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerConstitutionTextbox.TabIndex = 14;
            // 
            // PlayerIntelligenceTextbox
            // 
            this.PlayerIntelligenceTextbox.Location = new System.Drawing.Point(99, 111);
            this.PlayerIntelligenceTextbox.Name = "PlayerIntelligenceTextbox";
            this.PlayerIntelligenceTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerIntelligenceTextbox.TabIndex = 15;
            // 
            // PlayerWisdomTextbox
            // 
            this.PlayerWisdomTextbox.Location = new System.Drawing.Point(99, 128);
            this.PlayerWisdomTextbox.Name = "PlayerWisdomTextbox";
            this.PlayerWisdomTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerWisdomTextbox.TabIndex = 16;
            // 
            // PlayerCharismaTextbox
            // 
            this.PlayerCharismaTextbox.Location = new System.Drawing.Point(99, 145);
            this.PlayerCharismaTextbox.Name = "PlayerCharismaTextbox";
            this.PlayerCharismaTextbox.Size = new System.Drawing.Size(100, 20);
            this.PlayerCharismaTextbox.TabIndex = 17;
            // 
            // DungeonMasterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 844);
            this.Controls.Add(this.menuBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(724, 885);
            this.MinimumSize = new System.Drawing.Size(724, 883);
            this.Name = "DungeonMasterUI";
            this.Text = "DungeonMasterUI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DungeonMasterUI_Load);
            this.menuBar.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GenerateMapsButton.ResumeLayout(false);
            this.GenerateMapsButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfMaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MonsterAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfNPCs)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.PlayerCreationGroupBox.ResumeLayout(false);
            this.PlayerCreationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl menuBar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage GenerateMapsButton;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox GenerateLootOnMapCheckBox;
        private System.Windows.Forms.TextBox GridSizeTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown AmountOfMaps;
        private System.Windows.Forms.CheckBox GenerateEnemies;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox MapExampleThree;
        private System.Windows.Forms.RichTextBox MapExampleTwo;
        private System.Windows.Forms.RichTextBox MapExampleOne;
        private System.Windows.Forms.RichTextBox SavedMapsBox;
        private System.Windows.Forms.Button DeleteMap;
        private System.Windows.Forms.TextBox DifficultyText;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown MonsterAmount;
        private System.Windows.Forms.Button GenerateMonsterButton;
        private System.Windows.Forms.Button DeleteEnemyButton;
        private System.Windows.Forms.RichTextBox SavedEnemyBox;
        private System.Windows.Forms.RichTextBox EnemyExampleSix;
        private System.Windows.Forms.RichTextBox EnemyExampleFive;
        private System.Windows.Forms.RichTextBox EnemyExampleFour;
        private System.Windows.Forms.RichTextBox EnemyExampleThree;
        private System.Windows.Forms.RichTextBox EnemyExampleTwo;
        private System.Windows.Forms.RichTextBox EnemyExample;
        private System.Windows.Forms.NumericUpDown AmountOfNPCs;
        private System.Windows.Forms.Button GenerateNPCButton;
        private System.Windows.Forms.RichTextBox SavedNPCList;
        private System.Windows.Forms.RichTextBox NPCExampleOne;
        private System.Windows.Forms.Button DeleteNPC;
        private System.Windows.Forms.RichTextBox NPCExampleSix;
        private System.Windows.Forms.RichTextBox NPCExampleFive;
        private System.Windows.Forms.RichTextBox NPCExampleFour;
        private System.Windows.Forms.RichTextBox NPCExampleThree;
        private System.Windows.Forms.RichTextBox NPCExampleTwo;
        private System.Windows.Forms.RichTextBox SavedGameBox;
        private System.Windows.Forms.Button ImportGameButton;
        private System.Windows.Forms.Button ExportGameButton;
        private System.Windows.Forms.Button SaveGameButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private System.Windows.Forms.GroupBox PlayerCreationGroupBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox PlayerCharismaTextbox;
        private System.Windows.Forms.TextBox PlayerWisdomTextbox;
        private System.Windows.Forms.TextBox PlayerIntelligenceTextbox;
        private System.Windows.Forms.TextBox PlayerConstitutionTextbox;
        private System.Windows.Forms.TextBox PlayerDexterityTextbox;
        private System.Windows.Forms.TextBox PlayerStrengthTextbox;
        private System.Windows.Forms.TextBox PlayerMovementTextbox;
        private System.Windows.Forms.TextBox PlayerHealthTextbox;
        private System.Windows.Forms.TextBox PlayerNameTextbox;
        private System.Windows.Forms.Label PlayerCharismaLabel;
        private System.Windows.Forms.Label PlayerWisdomLabel;
        private System.Windows.Forms.Label PlayerIntelligenceLabel;
        private System.Windows.Forms.Label PlayerConstitutionLabel;
        private System.Windows.Forms.Label PlayerDexterityLabel;
        private System.Windows.Forms.Label PlayerStrengthLabel;
        private System.Windows.Forms.Label PlayerMovementLabel;
        private System.Windows.Forms.Label PlayerHealthLabel;
    }
}
