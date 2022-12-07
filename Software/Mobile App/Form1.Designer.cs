using System.Drawing;
using System.Windows.Forms;

namespace Mobile_App
{
    partial class Startup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Startup));
            this.TempFullscreen = new System.Windows.Forms.Button();
            this.ChooseAccountPanel = new System.Windows.Forms.Panel();
            this.ManageAccountsPictureBox = new System.Windows.Forms.PictureBox();
            this.AddAccountButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ManageAccountsPictureBox)).BeginInit();
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
            this.TempFullscreen.Size = new System.Drawing.Size(49, 27);
            this.TempFullscreen.TabIndex = 1;
            this.TempFullscreen.Text = "Full";
            this.TempFullscreen.UseVisualStyleBackColor = false;
            this.TempFullscreen.Click += new System.EventHandler(this.TempFullscreen_Click);
            // 
            // ChooseAccountPanel
            // 
            this.ChooseAccountPanel.Location = new System.Drawing.Point(0, 0);
            this.ChooseAccountPanel.Name = "ChooseAccountPanel";
            this.ChooseAccountPanel.Size = new System.Drawing.Size(200, 100);
            this.ChooseAccountPanel.TabIndex = 0;
            // 
            // ManageAccountsPictureBox
            // 
            this.ManageAccountsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ManageAccountsPictureBox.Image")));
            this.ManageAccountsPictureBox.Location = new System.Drawing.Point(151, 445);
            this.ManageAccountsPictureBox.Name = "ManageAccountsPictureBox";
            this.ManageAccountsPictureBox.Size = new System.Drawing.Size(128, 26);
            this.ManageAccountsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ManageAccountsPictureBox.TabIndex = 0;
            this.ManageAccountsPictureBox.TabStop = false;
            this.ManageAccountsPictureBox.Click += new System.EventHandler(this.ManageAccountsPictureBox_Click);
            // 
            // AddAccountButton
            // 
            this.AddAccountButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddAccountButton.FlatAppearance.BorderSize = 0;
            this.AddAccountButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddAccountButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddAccountButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AddAccountButton.Location = new System.Drawing.Point(12, 821);
            this.AddAccountButton.Name = "AddAccountButton";
            this.AddAccountButton.Size = new System.Drawing.Size(406, 76);
            this.AddAccountButton.TabIndex = 2;
            this.AddAccountButton.UseVisualStyleBackColor = true;
            this.AddAccountButton.Click += new System.EventHandler(this.AddAccountButton_Click);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(430, 932);
            this.Controls.Add(this.AddAccountButton);
            this.Controls.Add(this.ManageAccountsPictureBox);
            this.Controls.Add(this.TempFullscreen);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Startup";
            this.Text = "Startup";
            ((System.ComponentModel.ISupportInitialize)(this.ManageAccountsPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button TempFullscreen;
        private System.Windows.Forms.Panel ChooseAccountPanel;
        private System.Windows.Forms.PictureBox ManageAccountsPictureBox;
        private System.Windows.Forms.Button AddAccountButton;
    }
}

