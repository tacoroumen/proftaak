namespace Mobile_App
{
    partial class Form1
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
            this.TempFullscreen = new System.Windows.Forms.Button();
            this.ChooseAccountPanel = new System.Windows.Forms.Panel();
            this.ChooseAccountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TempFullscreen
            // 
            this.TempFullscreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TempFullscreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TempFullscreen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TempFullscreen.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.TempFullscreen.FlatAppearance.BorderSize = 0;
            this.TempFullscreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TempFullscreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TempFullscreen.ForeColor = System.Drawing.Color.White;
            this.TempFullscreen.Location = new System.Drawing.Point(0, 0);
            this.TempFullscreen.Margin = new System.Windows.Forms.Padding(0);
            this.TempFullscreen.Name = "TempFullscreen";
            this.TempFullscreen.Size = new System.Drawing.Size(160, 148);
            this.TempFullscreen.TabIndex = 1;
            this.TempFullscreen.Text = "Full Screen";
            this.TempFullscreen.UseVisualStyleBackColor = false;
            this.TempFullscreen.Click += new System.EventHandler(this.TempFullscreen_Click);
            // 
            // ChooseAccountPanel
            // 
            this.ChooseAccountPanel.Location = new System.Drawing.Point(131, 1022);
            this.ChooseAccountPanel.Margin = new System.Windows.Forms.Padding(4);
            this.ChooseAccountPanel.Name = "ChooseAccountPanel";
            this.ChooseAccountPanel.Size = new System.Drawing.Size(1120, 615);
            this.ChooseAccountPanel.TabIndex = 4;
            // 
            // ChooseAccountLabel
            // 
            this.ChooseAccountLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ChooseAccountLabel.AutoSize = true;
            this.ChooseAccountLabel.BackColor = System.Drawing.Color.Black;
            this.ChooseAccountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseAccountLabel.ForeColor = System.Drawing.Color.White;
            this.ChooseAccountLabel.Location = new System.Drawing.Point(119, 949);
            this.ChooseAccountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseAccountLabel.Name = "ChooseAccountLabel";
            this.ChooseAccountLabel.Size = new System.Drawing.Size(467, 69);
            this.ChooseAccountLabel.TabIndex = 5;
            this.ChooseAccountLabel.Text = "Choose Account";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1062, 1055);
            this.Controls.Add(this.ChooseAccountLabel);
            this.Controls.Add(this.ChooseAccountPanel);
            this.Controls.Add(this.TempFullscreen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TempFullscreen;
        private System.Windows.Forms.Panel ChooseAccountPanel;
        private System.Windows.Forms.Label ChooseAccountLabel;
    }
}

