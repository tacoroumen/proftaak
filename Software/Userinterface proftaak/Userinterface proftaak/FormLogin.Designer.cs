namespace Userinterface_proftaak
{
    partial class FormLogin
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
        public void InitializeComponent()
        {
            this.RadioButtonUser = new System.Windows.Forms.RadioButton();
            this.RadioButtonCompany = new System.Windows.Forms.RadioButton();
            this.ButtonScan = new System.Windows.Forms.Button();
            this.GroupBoxUser = new System.Windows.Forms.GroupBox();
            this.GroupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // RadioButtonUser
            // 
            this.RadioButtonUser.AutoSize = true;
            this.RadioButtonUser.Location = new System.Drawing.Point(6, 30);
            this.RadioButtonUser.Name = "RadioButtonUser";
            this.RadioButtonUser.Size = new System.Drawing.Size(137, 29);
            this.RadioButtonUser.TabIndex = 4;
            this.RadioButtonUser.TabStop = true;
            this.RadioButtonUser.Text = "Gebruiker";
            this.RadioButtonUser.UseVisualStyleBackColor = true;
            // 
            // RadioButtonCompany
            // 
            this.RadioButtonCompany.AutoSize = true;
            this.RadioButtonCompany.Location = new System.Drawing.Point(6, 65);
            this.RadioButtonCompany.Name = "RadioButtonCompany";
            this.RadioButtonCompany.Size = new System.Drawing.Size(166, 29);
            this.RadioButtonCompany.TabIndex = 5;
            this.RadioButtonCompany.TabStop = true;
            this.RadioButtonCompany.Text = "Vuilnisbedrijf";
            this.RadioButtonCompany.UseVisualStyleBackColor = true;
            // 
            // ButtonScan
            // 
            this.ButtonScan.Location = new System.Drawing.Point(445, 327);
            this.ButtonScan.Name = "ButtonScan";
            this.ButtonScan.Size = new System.Drawing.Size(189, 81);
            this.ButtonScan.TabIndex = 6;
            this.ButtonScan.Text = "Scan pasje";
            this.ButtonScan.UseVisualStyleBackColor = true;
            this.ButtonScan.Click += new System.EventHandler(this.ButtonScan_Click);
            // 
            // GroupBoxUser
            // 
            this.GroupBoxUser.Controls.Add(this.RadioButtonUser);
            this.GroupBoxUser.Controls.Add(this.RadioButtonCompany);
            this.GroupBoxUser.ForeColor = System.Drawing.Color.Black;
            this.GroupBoxUser.Location = new System.Drawing.Point(445, 182);
            this.GroupBoxUser.Name = "GroupBoxUser";
            this.GroupBoxUser.Size = new System.Drawing.Size(189, 100);
            this.GroupBoxUser.TabIndex = 7;
            this.GroupBoxUser.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 559);
            this.Controls.Add(this.GroupBoxUser);
            this.Controls.Add(this.ButtonScan);
            this.Name = "FormLogin";
            this.Text = "Login";
            this.GroupBoxUser.ResumeLayout(false);
            this.GroupBoxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RadioButton RadioButtonUser;
        public System.Windows.Forms.RadioButton RadioButtonCompany;
        public System.Windows.Forms.Button ButtonScan;
        private System.Windows.Forms.GroupBox GroupBoxUser;
    }
}