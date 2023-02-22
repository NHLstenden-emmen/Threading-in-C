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
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfMaps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteMap
            // 
            this.DeleteMap.Location = new System.Drawing.Point(277, 676);
            this.DeleteMap.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteMap.Name = "DeleteMap";
            this.DeleteMap.Size = new System.Drawing.Size(136, 58);
            this.DeleteMap.TabIndex = 22;
            this.DeleteMap.Text = "DeleteMap";
            this.DeleteMap.UseVisualStyleBackColor = true;
            // 
            // SavedMapsBox
            // 
            this.SavedMapsBox.Location = new System.Drawing.Point(22, 438);
            this.SavedMapsBox.Margin = new System.Windows.Forms.Padding(2);
            this.SavedMapsBox.Name = "SavedMapsBox";
            this.SavedMapsBox.Size = new System.Drawing.Size(647, 191);
            this.SavedMapsBox.TabIndex = 21;
            this.SavedMapsBox.Text = "Saved Maps Example";
            // 
            // MapExampleThree
            // 
            this.MapExampleThree.Location = new System.Drawing.Point(477, 143);
            this.MapExampleThree.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleThree.Name = "MapExampleThree";
            this.MapExampleThree.Size = new System.Drawing.Size(192, 191);
            this.MapExampleThree.TabIndex = 20;
            this.MapExampleThree.Text = "Map Example Three";
            // 
            // MapExampleTwo
            // 
            this.MapExampleTwo.Location = new System.Drawing.Point(246, 143);
            this.MapExampleTwo.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleTwo.Name = "MapExampleTwo";
            this.MapExampleTwo.Size = new System.Drawing.Size(192, 191);
            this.MapExampleTwo.TabIndex = 19;
            this.MapExampleTwo.Text = "Map Example Two";
            // 
            // MapExampleOne
            // 
            this.MapExampleOne.Location = new System.Drawing.Point(22, 143);
            this.MapExampleOne.Margin = new System.Windows.Forms.Padding(2);
            this.MapExampleOne.Name = "MapExampleOne";
            this.MapExampleOne.Size = new System.Drawing.Size(192, 191);
            this.MapExampleOne.TabIndex = 18;
            this.MapExampleOne.Text = "Map Example One";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(253, 91);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(91, 19);
            this.button2.TabIndex = 17;
            this.button2.Text = "Generate Maps";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AmountOfMaps
            // 
            this.AmountOfMaps.Location = new System.Drawing.Point(343, 91);
            this.AmountOfMaps.Margin = new System.Windows.Forms.Padding(2);
            this.AmountOfMaps.Name = "AmountOfMaps";
            this.AmountOfMaps.Size = new System.Drawing.Size(90, 20);
            this.AmountOfMaps.TabIndex = 16;
            // 
            // GenerateEnemies
            // 
            this.GenerateEnemies.AutoSize = true;
            this.GenerateEnemies.Location = new System.Drawing.Point(562, 27);
            this.GenerateEnemies.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateEnemies.Name = "GenerateEnemies";
            this.GenerateEnemies.Size = new System.Drawing.Size(113, 17);
            this.GenerateEnemies.TabIndex = 15;
            this.GenerateEnemies.Text = "Generate Enemies";
            this.GenerateEnemies.UseVisualStyleBackColor = true;
            // 
            // GridSizeTextBox
            // 
            this.GridSizeTextBox.Location = new System.Drawing.Point(261, 27);
            this.GridSizeTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.GridSizeTextBox.Name = "GridSizeTextBox";
            this.GridSizeTextBox.ReadOnly = true;
            this.GridSizeTextBox.Size = new System.Drawing.Size(76, 20);
            this.GridSizeTextBox.TabIndex = 14;
            this.GridSizeTextBox.Text = "Grid Size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(336, 27);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(90, 20);
            this.numericUpDown1.TabIndex = 13;
            // 
            // GenerateLootOnMapCheckBox
            // 
            this.GenerateLootOnMapCheckBox.AutoSize = true;
            this.GenerateLootOnMapCheckBox.Location = new System.Drawing.Point(22, 27);
            this.GenerateLootOnMapCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateLootOnMapCheckBox.Name = "GenerateLootOnMapCheckBox";
            this.GenerateLootOnMapCheckBox.Size = new System.Drawing.Size(93, 17);
            this.GenerateLootOnMapCheckBox.TabIndex = 12;
            this.GenerateLootOnMapCheckBox.Text = "Generate loot ";
            this.GenerateLootOnMapCheckBox.UseVisualStyleBackColor = true;
            // 
            // MapScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 756);
            this.Controls.Add(this.DeleteMap);
            this.Controls.Add(this.SavedMapsBox);
            this.Controls.Add(this.MapExampleThree);
            this.Controls.Add(this.MapExampleTwo);
            this.Controls.Add(this.MapExampleOne);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AmountOfMaps);
            this.Controls.Add(this.GenerateEnemies);
            this.Controls.Add(this.GridSizeTextBox);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.GenerateLootOnMapCheckBox);
            this.Name = "MapScreenForm";
            this.Text = "MapScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfMaps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteMap;
        private System.Windows.Forms.RichTextBox SavedMapsBox;
        private System.Windows.Forms.RichTextBox MapExampleThree;
        private System.Windows.Forms.RichTextBox MapExampleTwo;
        private System.Windows.Forms.RichTextBox MapExampleOne;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown AmountOfMaps;
        private System.Windows.Forms.CheckBox GenerateEnemies;
        private System.Windows.Forms.TextBox GridSizeTextBox;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox GenerateLootOnMapCheckBox;
    }
}