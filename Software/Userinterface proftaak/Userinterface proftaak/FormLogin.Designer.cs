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
        private void InitializeComponent()
        {
            this.PictureBoxEnglish = new System.Windows.Forms.PictureBox();
            this.PictureBoxDutch = new System.Windows.Forms.PictureBox();
            this.RadioButtonDutch = new System.Windows.Forms.RadioButton();
            this.RadioButtonEnglish = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDutch)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxEnglish
            // 
            this.PictureBoxEnglish.Image = global::Userinterface_proftaak.Properties.Resources.Flag_of_the_United_Kingdom_svg;
            this.PictureBoxEnglish.Location = new System.Drawing.Point(596, 92);
            this.PictureBoxEnglish.Name = "PictureBoxEnglish";
            this.PictureBoxEnglish.Size = new System.Drawing.Size(156, 92);
            this.PictureBoxEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxEnglish.TabIndex = 1;
            this.PictureBoxEnglish.TabStop = false;
            // 
            // PictureBoxDutch
            // 
            this.PictureBoxDutch.Image = global::Userinterface_proftaak.Properties.Resources._1200px_Flag_of_the_Netherlands_svg;
            this.PictureBoxDutch.Location = new System.Drawing.Point(354, 92);
            this.PictureBoxDutch.Name = "PictureBoxDutch";
            this.PictureBoxDutch.Size = new System.Drawing.Size(156, 92);
            this.PictureBoxDutch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxDutch.TabIndex = 0;
            this.PictureBoxDutch.TabStop = false;
            // 
            // RadioButtonDutch
            // 
            this.RadioButtonDutch.AutoSize = true;
            this.RadioButtonDutch.Location = new System.Drawing.Point(420, 190);
            this.RadioButtonDutch.Name = "RadioButtonDutch";
            this.RadioButtonDutch.Size = new System.Drawing.Size(27, 26);
            this.RadioButtonDutch.TabIndex = 2;
            this.RadioButtonDutch.TabStop = true;
            this.RadioButtonDutch.UseVisualStyleBackColor = true;
            // 
            // RadioButtonEnglish
            // 
            this.RadioButtonEnglish.AutoSize = true;
            this.RadioButtonEnglish.Location = new System.Drawing.Point(661, 190);
            this.RadioButtonEnglish.Name = "RadioButtonEnglish";
            this.RadioButtonEnglish.Size = new System.Drawing.Size(27, 26);
            this.RadioButtonEnglish.TabIndex = 3;
            this.RadioButtonEnglish.TabStop = true;
            this.RadioButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 714);
            this.Controls.Add(this.RadioButtonEnglish);
            this.Controls.Add(this.RadioButtonDutch);
            this.Controls.Add(this.PictureBoxEnglish);
            this.Controls.Add(this.PictureBoxDutch);
            this.Name = "FormLogin";
            this.Text = "Z";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDutch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxDutch;
        private System.Windows.Forms.PictureBox PictureBoxEnglish;
        private System.Windows.Forms.RadioButton RadioButtonDutch;
        private System.Windows.Forms.RadioButton RadioButtonEnglish;
    }
}