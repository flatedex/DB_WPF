namespace DB_WPF
{
    partial class About
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            this.label_About = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_About
            // 
            this.label_About.AutoSize = true;
            this.label_About.Location = new System.Drawing.Point(12, 9);
            this.label_About.Name = "label_About";
            this.label_About.Size = new System.Drawing.Size(414, 65);
            this.label_About.TabIndex = 2;
            this.label_About.Text = "Zakirov Ilyas, 404\r\n\r\n   The application is written by using WPF technology to ma" +
    "nipulate database\'s values.\r\n   The user can add, change and delete data from st" +
    "ore goods\'s database.\r\n   ";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 85);
            this.Controls.Add(this.label_About);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "About";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_About;
    }
}
