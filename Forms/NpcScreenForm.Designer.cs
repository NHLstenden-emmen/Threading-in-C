namespace Threading_in_C.Forms
{
    partial class NpcScreenForm
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
            this.DeleteNPC = new System.Windows.Forms.Button();
            this.AmountOfNPCs = new System.Windows.Forms.NumericUpDown();
            this.GenerateNPCButton = new System.Windows.Forms.Button();
            this.SavedNpcsListBox = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfNPCs)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteNPC
            // 
            this.DeleteNPC.Location = new System.Drawing.Point(303, 787);
            this.DeleteNPC.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteNPC.Name = "DeleteNPC";
            this.DeleteNPC.Size = new System.Drawing.Size(153, 71);
            this.DeleteNPC.TabIndex = 13;
            this.DeleteNPC.Text = "Delete NPC";
            this.DeleteNPC.UseVisualStyleBackColor = true;
            // 
            // AmountOfNPCs
            // 
            this.AmountOfNPCs.Location = new System.Drawing.Point(413, 23);
            this.AmountOfNPCs.Margin = new System.Windows.Forms.Padding(2);
            this.AmountOfNPCs.Name = "AmountOfNPCs";
            this.AmountOfNPCs.Size = new System.Drawing.Size(30, 20);
            this.AmountOfNPCs.TabIndex = 12;
            // 
            // GenerateNPCButton
            // 
            this.GenerateNPCButton.Location = new System.Drawing.Point(328, 23);
            this.GenerateNPCButton.Margin = new System.Windows.Forms.Padding(2);
            this.GenerateNPCButton.Name = "GenerateNPCButton";
            this.GenerateNPCButton.Size = new System.Drawing.Size(86, 19);
            this.GenerateNPCButton.TabIndex = 11;
            this.GenerateNPCButton.Text = "Generate NPC\'s";
            this.GenerateNPCButton.UseVisualStyleBackColor = true;
            this.GenerateNPCButton.Click += new System.EventHandler(this.GenerateNPCButton_Click);
            // 
            // SavedNpcsListBox
            // 
            this.SavedNpcsListBox.FormattingEnabled = true;
            this.SavedNpcsListBox.Location = new System.Drawing.Point(27, 63);
            this.SavedNpcsListBox.Name = "SavedNpcsListBox";
            this.SavedNpcsListBox.Size = new System.Drawing.Size(694, 654);
            this.SavedNpcsListBox.TabIndex = 27;
            // 
            // NpcScreenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 923);
            this.Controls.Add(this.SavedNpcsListBox);
            this.Controls.Add(this.DeleteNPC);
            this.Controls.Add(this.AmountOfNPCs);
            this.Controls.Add(this.GenerateNPCButton);
            this.Name = "NpcScreenForm";
            this.Text = "NpcScreenForm";
            ((System.ComponentModel.ISupportInitialize)(this.AmountOfNPCs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button DeleteNPC;
        private System.Windows.Forms.NumericUpDown AmountOfNPCs;
        private System.Windows.Forms.Button GenerateNPCButton;
        private System.Windows.Forms.ListBox SavedNpcsListBox;
    }
}