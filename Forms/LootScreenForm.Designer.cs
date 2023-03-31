namespace Threading_in_C.Forms
{
    partial class LootScreenForm
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
            this.SavedItemsListBox = new System.Windows.Forms.ListBox();
            this.DeleteItem = new System.Windows.Forms.Button();
            this.AmountOfItems = new System.Windows.Forms.NumericUpDown();
            this.GenerateItemButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfItems)).BeginInit();
            this.SuspendLayout();
            // 
            // SavedItemsListBox
            // 
            this.SavedItemsListBox.FormattingEnabled = true;
            this.SavedItemsListBox.Location = new System.Drawing.Point(53, 55);
            this.SavedItemsListBox.Name = "SavedItemsListBox";
            this.SavedItemsListBox.Size = new System.Drawing.Size(694, 654);
            this.SavedItemsListBox.TabIndex = 31;
            this.SavedItemsListBox.DoubleClick += new System.EventHandler(this.SavedItemsListBox_DoubleClick);
            // 
            // DeleteItem
            // 
            this.DeleteItem.Location = new System.Drawing.Point(53, 727);
            this.DeleteItem.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteItem.Name = "DeleteItem";
            this.DeleteItem.Size = new System.Drawing.Size(153, 71);
            this.DeleteItem.TabIndex = 30;
            this.DeleteItem.Text = "Delete All";
            this.DeleteItem.UseVisualStyleBackColor = true;
            this.DeleteItem.Click += new System.EventHandler(this.DeleteItem_Click);
            // 
            // AmountOfItems
            // 
            this.AmountOfItems.Location = new System.Drawing.Point(138, 22);
            this.AmountOfItems.Margin = new System.Windows.Forms.Padding(2);
            this.AmountOfItems.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.AmountOfItems.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.AmountOfItems.Name = "AmountOfItems";
            this.AmountOfItems.Size = new System.Drawing.Size(30, 20);
            this.AmountOfItems.TabIndex = 29;
            this.AmountOfItems.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // GenerateItemButton
            // 
            this.GenerateItemButton.Location = new System.Drawing.Point(53, 22);
            this.GenerateItemButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateItemButton.Name = "GenerateItemButton";
            this.GenerateItemButton.Size = new System.Drawing.Size(86, 19);
            this.GenerateItemButton.TabIndex = 28;
            this.GenerateItemButton.Text = "Generate NPC\'s";
            this.GenerateItemButton.UseVisualStyleBackColor = true;
            this.GenerateItemButton.Click += new System.EventHandler(this.GenerateItemButton_Click);
            // 
            // LootScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 865);
            this.Controls.Add(this.SavedItemsListBox);
            this.Controls.Add(this.DeleteItem);
            this.Controls.Add(this.AmountOfItems);
            this.Controls.Add(this.GenerateItemButton);
            this.Name = "LootScreenForm";
            this.Text = "LootScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox SavedItemsListBox;
        private System.Windows.Forms.Button DeleteItem;
        private System.Windows.Forms.NumericUpDown AmountOfItems;
        private System.Windows.Forms.Button GenerateItemButton;
    }
}