namespace Threading_in_C.Forms
{
    partial class DisplayLootScreenForm
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
            this.textBoxLootInfo = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // textBoxLootInfo
            // 
            this.textBoxLootInfo.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxLootInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxLootInfo.Location = new System.Drawing.Point(12, 12);
            this.textBoxLootInfo.Name = "textBoxLootInfo";
            this.textBoxLootInfo.Size = new System.Drawing.Size(456, 256);
            this.textBoxLootInfo.TabIndex = 2;
            this.textBoxLootInfo.Text = "";
            this.textBoxLootInfo.Click += new System.EventHandler(this.DisplayLootScreenForm_Click);
            // 
            // DisplayLootScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 256);
            this.Controls.Add(this.textBoxLootInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(455, 256);
            this.Name = "DisplayLootScreenForm";
            this.Text = "DisplayLootScreenForm";
            this.Click += new System.EventHandler(this.DisplayLootScreenForm_Click);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxLootInfo;
    }
}