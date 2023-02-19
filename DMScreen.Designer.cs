namespace Threading_in_C
{
<<<<<<<< HEAD:DungeonMasterUI.Designer.cs
    partial class DungeonMasterUI
========
    partial class DMScreen
>>>>>>>> 6330bd14cb7222411d7364c1884b45e29e316337:DMScreen.Designer.cs
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
            this.SuspendLayout();
            // 
            // DungeonMasterUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<<< HEAD:DungeonMasterUI.Designer.cs
            this.Name = "DungeonMasterUI";
            this.Text = "DungeonMasterUI";
            this.Load += new System.EventHandler(this.DungeonMasterUI_Load);
            this.ResumeLayout(false);

========
            this.Text = "DMScreen";
>>>>>>>> 6330bd14cb7222411d7364c1884b45e29e316337:DMScreen.Designer.cs
        }

        #endregion
    }
}