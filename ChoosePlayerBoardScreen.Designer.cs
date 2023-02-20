namespace Threading_in_C
{
    partial class ChoosePlayerBoardScreen
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
            this.SelectPlayerBoardScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectPlayerBoardScreen
            // 
            this.SelectPlayerBoardScreen.Location = new System.Drawing.Point(307, 354);
            this.SelectPlayerBoardScreen.Name = "SelectPlayerBoardScreen";
            this.SelectPlayerBoardScreen.Size = new System.Drawing.Size(211, 23);
            this.SelectPlayerBoardScreen.TabIndex = 0;
            this.SelectPlayerBoardScreen.Text = "Choose selected Screen";
            this.SelectPlayerBoardScreen.UseVisualStyleBackColor = true;
            this.SelectPlayerBoardScreen.Click += new System.EventHandler(this.SelectPlayerBoardScreen_Click);
            // 
            // ChoosePlayerBoardScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SelectPlayerBoardScreen);
            this.Name = "ChoosePlayerBoardScreen";
            this.Text = "ChoosePlayerBoardScreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectPlayerBoardScreen;
    }
}