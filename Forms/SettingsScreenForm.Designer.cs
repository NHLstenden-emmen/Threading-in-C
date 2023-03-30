namespace Threading_in_C.Forms
{
    partial class SettingsScreenForm
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SavedGameBox = new System.Windows.Forms.RichTextBox();
            this.ImportGameButton = new System.Windows.Forms.Button();
            this.ExportGameButton = new System.Windows.Forms.Button();
            this.SaveGameButton = new System.Windows.Forms.Button();
            this.btnResetTurnCounter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 510);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(338, 20);
            this.textBox1.TabIndex = 9;
            this.textBox1.Text = "Last saved on ... ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SavedGameBox
            // 
            this.SavedGameBox.Location = new System.Drawing.Point(335, 37);
            this.SavedGameBox.Margin = new System.Windows.Forms.Padding(2);
            this.SavedGameBox.Name = "SavedGameBox";
            this.SavedGameBox.Size = new System.Drawing.Size(321, 400);
            this.SavedGameBox.TabIndex = 8;
            this.SavedGameBox.Text = "Save games appear here";
            // 
            // ImportGameButton
            // 
            this.ImportGameButton.Location = new System.Drawing.Point(27, 219);
            this.ImportGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ImportGameButton.Name = "ImportGameButton";
            this.ImportGameButton.Size = new System.Drawing.Size(182, 66);
            this.ImportGameButton.TabIndex = 7;
            this.ImportGameButton.Text = "Import Game";
            this.ImportGameButton.UseVisualStyleBackColor = true;
            this.ImportGameButton.Click += new System.EventHandler(this.ImportGameButton_Click);
            // 
            // ExportGameButton
            // 
            this.ExportGameButton.Location = new System.Drawing.Point(27, 128);
            this.ExportGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExportGameButton.Name = "ExportGameButton";
            this.ExportGameButton.Size = new System.Drawing.Size(182, 66);
            this.ExportGameButton.TabIndex = 6;
            this.ExportGameButton.Text = "Export Game";
            this.ExportGameButton.UseVisualStyleBackColor = true;
            this.ExportGameButton.Click += new System.EventHandler(this.ExportGameButton_Click);
            // 
            // SaveGameButton
            // 
            this.SaveGameButton.Location = new System.Drawing.Point(27, 37);
            this.SaveGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveGameButton.Name = "SaveGameButton";
            this.SaveGameButton.Size = new System.Drawing.Size(182, 66);
            this.SaveGameButton.TabIndex = 5;
            this.SaveGameButton.Text = "Save Game";
            this.SaveGameButton.UseVisualStyleBackColor = true;
            // 
            // btnResetTurnCounter
            // 
            this.btnResetTurnCounter.Location = new System.Drawing.Point(27, 317);
            this.btnResetTurnCounter.Margin = new System.Windows.Forms.Padding(2);
            this.btnResetTurnCounter.Name = "btnResetTurnCounter";
            this.btnResetTurnCounter.Size = new System.Drawing.Size(182, 66);
            this.btnResetTurnCounter.TabIndex = 10;
            this.btnResetTurnCounter.Text = "Reset Turn Counter";
            this.btnResetTurnCounter.UseVisualStyleBackColor = true;
            this.btnResetTurnCounter.Click += new System.EventHandler(this.btnResetTurnCounter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SettingsScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 569);
            this.Controls.Add(this.btnResetTurnCounter);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SavedGameBox);
            this.Controls.Add(this.ImportGameButton);
            this.Controls.Add(this.ExportGameButton);
            this.Controls.Add(this.SaveGameButton);
            this.Name = "SettingsScreenForm";
            this.Text = "SettingsScreenForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox SavedGameBox;
        private System.Windows.Forms.Button ImportGameButton;
        private System.Windows.Forms.Button ExportGameButton;
        private System.Windows.Forms.Button SaveGameButton;
        private System.Windows.Forms.Button btnResetTurnCounter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}