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
            this.masterOverrideCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfMaps)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteMap
            // 
            this.DeleteMap.Location = new System.Drawing.Point(369, 832);
            this.DeleteMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteMap.Name = "DeleteMap";
            this.DeleteMap.Size = new System.Drawing.Size(181, 71);
            this.DeleteMap.TabIndex = 22;
            this.DeleteMap.Text = "DeleteMap";
            this.DeleteMap.UseVisualStyleBackColor = true;
            // 
            // SavedMapsBox
            // 
            this.SavedMapsBox.Location = new System.Drawing.Point(29, 539);
            this.SavedMapsBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SavedMapsBox.Name = "SavedMapsBox";
            this.SavedMapsBox.Size = new System.Drawing.Size(861, 234);
            this.SavedMapsBox.TabIndex = 21;
            this.SavedMapsBox.Text = "Saved Maps Example";
            // 
            // MapExampleThree
            // 
            this.MapExampleThree.Location = new System.Drawing.Point(636, 176);
            this.MapExampleThree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapExampleThree.Name = "MapExampleThree";
            this.MapExampleThree.Size = new System.Drawing.Size(255, 234);
            this.MapExampleThree.TabIndex = 20;
            this.MapExampleThree.Text = "Map Example Three";
            // 
            // MapExampleTwo
            // 
            this.MapExampleTwo.Location = new System.Drawing.Point(328, 176);
            this.MapExampleTwo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapExampleTwo.Name = "MapExampleTwo";
            this.MapExampleTwo.Size = new System.Drawing.Size(255, 234);
            this.MapExampleTwo.TabIndex = 19;
            this.MapExampleTwo.Text = "Map Example Two";
            // 
            // MapExampleOne
            // 
            this.MapExampleOne.Location = new System.Drawing.Point(29, 176);
            this.MapExampleOne.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MapExampleOne.Name = "MapExampleOne";
            this.MapExampleOne.Size = new System.Drawing.Size(255, 234);
            this.MapExampleOne.TabIndex = 18;
            this.MapExampleOne.Text = "Map Example One";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(337, 112);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Generate Maps";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AmountOfMaps
            // 
            this.AmountOfMaps.Location = new System.Drawing.Point(457, 112);
            this.AmountOfMaps.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AmountOfMaps.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.AmountOfMaps.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.AmountOfMaps.Name = "AmountOfMaps";
            this.AmountOfMaps.Size = new System.Drawing.Size(120, 22);
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
            this.masterOverrideCheckbox.Location = new System.Drawing.Point(784, 832);
            this.masterOverrideCheckbox.Name = "masterOverrideCheckbox";
            this.masterOverrideCheckbox.Size = new System.Drawing.Size(125, 20);
            this.masterOverrideCheckbox.TabIndex = 23;
            this.masterOverrideCheckbox.Text = "Master Override";
            this.masterOverrideCheckbox.UseVisualStyleBackColor = true;
            // 
            // MapScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 930);
            this.Controls.Add(this.masterOverrideCheckbox);
            this.Controls.Add(this.DeleteMap);
            this.Controls.Add(this.SavedMapsBox);
            this.Controls.Add(this.MapExampleThree);
            this.Controls.Add(this.MapExampleTwo);
            this.Controls.Add(this.MapExampleOne);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AmountOfMaps);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MapScreenForm";
            this.Text = "MapScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfMaps)).EndInit();
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
        private System.Windows.Forms.CheckBox masterOverrideCheckbox;
    }
}