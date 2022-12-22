using System.Drawing;
using System.Windows.Forms;

namespace Userinterface_proftaak
{
    partial class FormSelectMaterials
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSelectMaterials));
            this.ButtonSignOut = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.ButtonPlastic = new System.Windows.Forms.Button();
            this.ButtonPaper = new System.Windows.Forms.Button();
            this.ButtonGeneralWaste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonSignOut
            // 
            this.ButtonSignOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonSignOut.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSignOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonSignOut.FlatAppearance.BorderSize = 0;
            this.ButtonSignOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonSignOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonSignOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSignOut.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonSignOut.Location = new System.Drawing.Point(1591, 3);
            this.ButtonSignOut.Name = "ButtonSignOut";
            this.ButtonSignOut.Size = new System.Drawing.Size(291, 90);
            this.ButtonSignOut.TabIndex = 8;
            this.ButtonSignOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ButtonSignOut.UseVisualStyleBackColor = false;
            this.ButtonSignOut.Click += new System.EventHandler(this.ButtonSignOut_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.BackColor = System.Drawing.Color.White;
            this.LabelUsername.Font = new System.Drawing.Font("HP Simplified", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(112)))), ((int)(((byte)(112)))));
            this.LabelUsername.Location = new System.Drawing.Point(829, 111);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(205, 31);
            this.LabelUsername.TabIndex = 12;
            this.LabelUsername.Text = "Gebruikersnaam";
            // 
            // ButtonPlastic
            // 
            this.ButtonPlastic.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPlastic.FlatAppearance.BorderSize = 0;
            this.ButtonPlastic.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonPlastic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonPlastic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPlastic.Location = new System.Drawing.Point(95, 589);
            this.ButtonPlastic.Name = "ButtonPlastic";
            this.ButtonPlastic.Size = new System.Drawing.Size(530, 159);
            this.ButtonPlastic.TabIndex = 15;
            this.ButtonPlastic.UseVisualStyleBackColor = false;
            this.ButtonPlastic.Click += new System.EventHandler(this.ButtonPlastic_Click);
            // 
            // ButtonPaper
            // 
            this.ButtonPaper.BackColor = System.Drawing.Color.Transparent;
            this.ButtonPaper.FlatAppearance.BorderSize = 0;
            this.ButtonPaper.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonPaper.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonPaper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPaper.Location = new System.Drawing.Point(686, 589);
            this.ButtonPaper.Name = "ButtonPaper";
            this.ButtonPaper.Size = new System.Drawing.Size(519, 159);
            this.ButtonPaper.TabIndex = 16;
            this.ButtonPaper.UseVisualStyleBackColor = false;
            this.ButtonPaper.Click += new System.EventHandler(this.ButtonPaper_Click);
            // 
            // ButtonGeneralWaste
            // 
            this.ButtonGeneralWaste.BackColor = System.Drawing.Color.Transparent;
            this.ButtonGeneralWaste.FlatAppearance.BorderSize = 0;
            this.ButtonGeneralWaste.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.ButtonGeneralWaste.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.ButtonGeneralWaste.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonGeneralWaste.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonGeneralWaste.Location = new System.Drawing.Point(1267, 590);
            this.ButtonGeneralWaste.Name = "ButtonGeneralWaste";
            this.ButtonGeneralWaste.Size = new System.Drawing.Size(524, 158);
            this.ButtonGeneralWaste.TabIndex = 17;
            this.ButtonGeneralWaste.UseVisualStyleBackColor = false;
            this.ButtonGeneralWaste.Click += new System.EventHandler(this.ButtonGeneralWaste_Click);
            // 
            // FormSelectMaterials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonGeneralWaste);
            this.Controls.Add(this.ButtonPaper);
            this.Controls.Add(this.ButtonSignOut);
            this.Controls.Add(this.ButtonPlastic);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.Name = "FormSelectMaterials";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form User";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelUsername;
        private Button ButtonSignOut;
        private Button ButtonPlastic;
        private Button ButtonPaper;
        private Button ButtonGeneralWaste;
    }
}

