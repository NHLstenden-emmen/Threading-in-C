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
            this.ImportGameButton = new System.Windows.Forms.Button();
            this.ExportGameButton = new System.Windows.Forms.Button();
            this.btnResetTurnCounter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // ImportGameButton
            // 
            this.ImportGameButton.Location = new System.Drawing.Point(248, 306);
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
            this.ExportGameButton.Location = new System.Drawing.Point(248, 187);
            this.ExportGameButton.Margin = new System.Windows.Forms.Padding(2);
            this.ExportGameButton.Name = "ExportGameButton";
            this.ExportGameButton.Size = new System.Drawing.Size(182, 66);
            this.ExportGameButton.TabIndex = 6;
            this.ExportGameButton.Text = "Export Game";
            this.ExportGameButton.UseVisualStyleBackColor = true;
            this.ExportGameButton.Click += new System.EventHandler(this.ExportGameButton_Click);
            // 
            // btnResetTurnCounter
            // 
            this.btnResetTurnCounter.Location = new System.Drawing.Point(248, 426);
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
            this.Controls.Add(this.ImportGameButton);
            this.Controls.Add(this.ExportGameButton);
            this.Name = "SettingsScreenForm";
            this.Text = "SettingsScreenForm";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ImportGameButton;
        private System.Windows.Forms.Button ExportGameButton;
        private System.Windows.Forms.Button btnResetTurnCounter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}