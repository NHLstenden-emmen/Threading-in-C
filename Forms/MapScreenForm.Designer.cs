namespace Threading_in_C.Forms
{
    partial class MapScreenForm
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
            this.MapExampleThree = new System.Windows.Forms.RichTextBox();
            this.MapExampleTwo = new System.Windows.Forms.RichTextBox();
            this.MapExampleOne = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.AmountOfMaps = new System.Windows.Forms.NumericUpDown();
            this.masterOverrideCheckbox = new System.Windows.Forms.CheckBox();
            this.obstacleButton = new System.Windows.Forms.Button();
            this.objectNameBox = new System.Windows.Forms.TextBox();
            this.MapExampleFour = new System.Windows.Forms.RichTextBox();
            this.MapExampleFive = new System.Windows.Forms.RichTextBox();
            this.MapExampleSix = new System.Windows.Forms.RichTextBox();
            this.MapExampleSeven = new System.Windows.Forms.RichTextBox();
            this.MapExampleEight = new System.Windows.Forms.RichTextBox();
            this.MapExampleNine = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // MapExampleThree
            // 
            this.MapExampleThree.Location = new System.Drawing.Point(477, 143);
            this.MapExampleThree.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapExampleThree.Name = "MapExampleThree";
            this.MapExampleThree.Size = new System.Drawing.Size(192, 191);
            this.MapExampleThree.TabIndex = 20;
            this.MapExampleThree.Text = "Map Example Three";
            this.MapExampleThree.DoubleClick += new System.EventHandler(this.SelectMap);
            // 
            // MapExampleTwo
            // 
            this.MapExampleTwo.Location = new System.Drawing.Point(246, 143);
            this.MapExampleTwo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapExampleTwo.Name = "MapExampleTwo";
            this.MapExampleTwo.Size = new System.Drawing.Size(192, 191);
            this.MapExampleTwo.TabIndex = 19;
            this.MapExampleTwo.Text = "Map Example Two";
            this.MapExampleTwo.DoubleClick += new System.EventHandler(this.SelectMap);
            // 
            // MapExampleOne
            // 
            this.MapExampleOne.Location = new System.Drawing.Point(22, 143);
            this.MapExampleOne.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MapExampleOne.Name = "MapExampleOne";
            this.MapExampleOne.Size = new System.Drawing.Size(192, 191);
            this.MapExampleOne.TabIndex = 18;
            this.MapExampleOne.Text = "Map Example One";
            this.MapExampleOne.DoubleClick += new System.EventHandler(this.SelectMap);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 19);
            this.button2.TabIndex = 17;
            this.button2.Text = "Generate Maps";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AmountOfMaps
            // 
            this.AmountOfMaps.Location = new System.Drawing.Point(343, 91);
            this.AmountOfMaps.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.AmountOfMaps.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.AmountOfMaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountOfMaps.Name = "AmountOfMaps";
            this.AmountOfMaps.Size = new System.Drawing.Size(90, 20);
            this.AmountOfMaps.TabIndex = 16;
            this.AmountOfMaps.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // masterOverrideCheckbox
            // 
            this.masterOverrideCheckbox.AutoSize = true;
            this.masterOverrideCheckbox.Location = new System.Drawing.Point(531, 91);
            this.masterOverrideCheckbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.masterOverrideCheckbox.Name = "masterOverrideCheckbox";
            this.masterOverrideCheckbox.Size = new System.Drawing.Size(101, 17);
            this.masterOverrideCheckbox.TabIndex = 23;
            this.masterOverrideCheckbox.Text = "Master Override";
            this.masterOverrideCheckbox.UseVisualStyleBackColor = true;
            // 
            // obstacleButton
            // 
            this.obstacleButton.Location = new System.Drawing.Point(63, 91);
            this.obstacleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.obstacleButton.Name = "obstacleButton";
            this.obstacleButton.Size = new System.Drawing.Size(96, 30);
            this.obstacleButton.TabIndex = 24;
            this.obstacleButton.Text = "Place obstacle";
            this.obstacleButton.UseVisualStyleBackColor = true;
            this.obstacleButton.Click += new System.EventHandler(this.obstacleButton_Click);
            // 
            // objectNameBox
            // 
            this.objectNameBox.Location = new System.Drawing.Point(63, 43);
            this.objectNameBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.objectNameBox.Name = "objectNameBox";
            this.objectNameBox.Size = new System.Drawing.Size(97, 20);
            this.objectNameBox.TabIndex = 25;
            this.objectNameBox.Text = "Obstacle Name";
            // 
            // MapExampleFour
            // 
            this.MapExampleFour.Location = new System.Drawing.Point(22, 348);
            this.MapExampleFour.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleFour.Name = "MapExampleFour";
            this.MapExampleFour.Size = new System.Drawing.Size(192, 191);
            this.MapExampleFour.TabIndex = 26;
            this.MapExampleFour.Text = "Map Example Four";
            // 
            // MapExampleFive
            // 
            this.MapExampleFive.Location = new System.Drawing.Point(246, 348);
            this.MapExampleFive.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleFive.Name = "MapExampleFive";
            this.MapExampleFive.Size = new System.Drawing.Size(192, 191);
            this.MapExampleFive.TabIndex = 27;
            this.MapExampleFive.Text = "Map Example Five";
            // 
            // MapExampleSix
            // 
            this.MapExampleSix.Location = new System.Drawing.Point(477, 348);
            this.MapExampleSix.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleSix.Name = "MapExampleSix";
            this.MapExampleSix.Size = new System.Drawing.Size(192, 191);
            this.MapExampleSix.TabIndex = 28;
            this.MapExampleSix.Text = "Map Example Six";
            // 
            // MapExampleSeven
            // 
            this.MapExampleSeven.Location = new System.Drawing.Point(22, 554);
            this.MapExampleSeven.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleSeven.Name = "MapExampleSeven";
            this.MapExampleSeven.Size = new System.Drawing.Size(192, 191);
            this.MapExampleSeven.TabIndex = 29;
            this.MapExampleSeven.Text = "Map Example Seven";
            // 
            // MapExampleEight
            // 
            this.MapExampleEight.Location = new System.Drawing.Point(241, 554);
            this.MapExampleEight.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleEight.Name = "MapExampleEight";
            this.MapExampleEight.Size = new System.Drawing.Size(192, 191);
            this.MapExampleEight.TabIndex = 30;
            this.MapExampleEight.Text = "Map Example Eight";
            // 
            // MapExampleNine
            // 
            this.MapExampleNine.Location = new System.Drawing.Point(477, 554);
            this.MapExampleNine.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleNine.Name = "MapExampleNine";
            this.MapExampleNine.Size = new System.Drawing.Size(192, 191);
            this.MapExampleNine.TabIndex = 31;
            this.MapExampleNine.Text = "Map Example Nine";
            // 
            // MapScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 756);
            this.Controls.Add(this.MapExampleNine);
            this.Controls.Add(this.MapExampleEight);
            this.Controls.Add(this.MapExampleSeven);
            this.Controls.Add(this.MapExampleSix);
            this.Controls.Add(this.MapExampleFive);
            this.Controls.Add(this.MapExampleFour);
            this.Controls.Add(this.objectNameBox);
            this.Controls.Add(this.obstacleButton);
            this.Controls.Add(this.masterOverrideCheckbox);
            this.Controls.Add(this.MapExampleThree);
            this.Controls.Add(this.MapExampleTwo);
            this.Controls.Add(this.MapExampleOne);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AmountOfMaps);
            this.Name = "MapScreenForm";
            this.Text = "MapScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfMaps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox MapExampleThree;
        private System.Windows.Forms.RichTextBox MapExampleTwo;
        private System.Windows.Forms.RichTextBox MapExampleOne;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown AmountOfMaps;
        private System.Windows.Forms.CheckBox masterOverrideCheckbox;
        private System.Windows.Forms.Button obstacleButton;
        private System.Windows.Forms.TextBox objectNameBox;
        private System.Windows.Forms.RichTextBox MapExampleFour;
        private System.Windows.Forms.RichTextBox MapExampleFive;
        private System.Windows.Forms.RichTextBox MapExampleSix;
        private System.Windows.Forms.RichTextBox MapExampleSeven;
        private System.Windows.Forms.RichTextBox MapExampleEight;
        private System.Windows.Forms.RichTextBox MapExampleNine;
    }
}