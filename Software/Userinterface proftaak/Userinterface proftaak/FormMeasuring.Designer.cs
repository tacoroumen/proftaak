namespace Userinterface_proftaak
{
    partial class FormMeasuring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMeasuring));
            this.LabelUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.BackColor = System.Drawing.Color.White;
            this.LabelUsername.Font = new System.Drawing.Font("HP Simplified", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.LabelUsername.Location = new System.Drawing.Point(829, 111);
            this.LabelUsername.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(205, 31);
            this.LabelUsername.TabIndex = 13;
            this.LabelUsername.Text = "Gebruikersnaam";
            // 
            // FormMeasuring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.LabelUsername);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormMeasuring";
            this.Text = "FormMeasuring";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMeasuring_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelUsername;
    }
}