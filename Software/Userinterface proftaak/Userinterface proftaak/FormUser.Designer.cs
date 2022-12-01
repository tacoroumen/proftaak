using System.Windows.Forms;

namespace Userinterface_proftaak
{
    partial class FormUser
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
            this.ComboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.LabelMaterials = new System.Windows.Forms.Label();
            this.LabelStart = new System.Windows.Forms.Label();
            this.LabelStop = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.RadioButtonDutch = new System.Windows.Forms.RadioButton();
            this.RadioButtonEnglish = new System.Windows.Forms.RadioButton();
            this.PictureBoxEnglish = new System.Windows.Forms.PictureBox();
            this.PictureBoxDutch = new System.Windows.Forms.PictureBox();
            this.ListBoxHistory = new System.Windows.Forms.ListBox();
            this.LabelTest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEnglish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDutch)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboBoxMaterials
            // 
            this.ComboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMaterials.FormattingEnabled = true;
            this.ComboBoxMaterials.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.ComboBoxMaterials.Location = new System.Drawing.Point(404, 437);
            this.ComboBoxMaterials.Name = "ComboBoxMaterials";
            this.ComboBoxMaterials.Size = new System.Drawing.Size(253, 33);
            this.ComboBoxMaterials.TabIndex = 0;
            // 
            // LabelMaterials
            // 
            this.LabelMaterials.AutoSize = true;
            this.LabelMaterials.Location = new System.Drawing.Point(482, 409);
            this.LabelMaterials.Name = "LabelMaterials";
            this.LabelMaterials.Size = new System.Drawing.Size(101, 25);
            this.LabelMaterials.TabIndex = 1;
            this.LabelMaterials.Text = "Materiaal";
            // 
            // LabelStart
            // 
            this.LabelStart.AutoSize = true;
            this.LabelStart.Location = new System.Drawing.Point(12, 268);
            this.LabelStart.Name = "LabelStart";
            this.LabelStart.Size = new System.Drawing.Size(105, 25);
            this.LabelStart.TabIndex = 5;
            this.LabelStart.Text = "Test Start";
            // 
            // LabelStop
            // 
            this.LabelStop.AutoSize = true;
            this.LabelStop.Location = new System.Drawing.Point(452, 521);
            this.LabelStop.Name = "LabelStop";
            this.LabelStop.Size = new System.Drawing.Size(164, 25);
            this.LabelStop.TabIndex = 6;
            this.LabelStop.Text = "Beëindig sessie";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(12, 296);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(158, 89);
            this.ButtonStart.TabIndex = 7;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(457, 549);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(157, 85);
            this.ButtonStop.TabIndex = 8;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(449, 296);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(170, 25);
            this.LabelUsername.TabIndex = 12;
            this.LabelUsername.Text = "Gebruikersnaam";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(404, 324);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(253, 31);
            this.TextBoxUsername.TabIndex = 13;
            // 
            // RadioButtonDutch
            // 
            this.RadioButtonDutch.AutoSize = true;
            this.RadioButtonDutch.Location = new System.Drawing.Point(444, 242);
            this.RadioButtonDutch.Name = "RadioButtonDutch";
            this.RadioButtonDutch.Size = new System.Drawing.Size(27, 26);
            this.RadioButtonDutch.TabIndex = 16;
            this.RadioButtonDutch.TabStop = true;
            this.RadioButtonDutch.UseVisualStyleBackColor = true;
            // 
            // RadioButtonEnglish
            // 
            this.RadioButtonEnglish.AutoSize = true;
            this.RadioButtonEnglish.Location = new System.Drawing.Point(589, 242);
            this.RadioButtonEnglish.Name = "RadioButtonEnglish";
            this.RadioButtonEnglish.Size = new System.Drawing.Size(27, 26);
            this.RadioButtonEnglish.TabIndex = 17;
            this.RadioButtonEnglish.TabStop = true;
            this.RadioButtonEnglish.UseVisualStyleBackColor = true;
            // 
            // PictureBoxEnglish
            // 
            this.PictureBoxEnglish.Image = global::Userinterface_proftaak.Properties.Resources.Flag_of_the_United_Kingdom_svg;
            this.PictureBoxEnglish.Location = new System.Drawing.Point(547, 164);
            this.PictureBoxEnglish.Name = "PictureBoxEnglish";
            this.PictureBoxEnglish.Size = new System.Drawing.Size(110, 66);
            this.PictureBoxEnglish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxEnglish.TabIndex = 19;
            this.PictureBoxEnglish.TabStop = false;
            // 
            // PictureBoxDutch
            // 
            this.PictureBoxDutch.ErrorImage = null;
            this.PictureBoxDutch.Image = global::Userinterface_proftaak.Properties.Resources._1200px_Flag_of_the_Netherlands_svg;
            this.PictureBoxDutch.Location = new System.Drawing.Point(404, 164);
            this.PictureBoxDutch.Name = "PictureBoxDutch";
            this.PictureBoxDutch.Size = new System.Drawing.Size(110, 66);
            this.PictureBoxDutch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxDutch.TabIndex = 18;
            this.PictureBoxDutch.TabStop = false;
            // 
            // ListBoxHistory
            // 
            this.ListBoxHistory.FormattingEnabled = true;
            this.ListBoxHistory.ItemHeight = 25;
            this.ListBoxHistory.Location = new System.Drawing.Point(12, 455);
            this.ListBoxHistory.Name = "ListBoxHistory";
            this.ListBoxHistory.Size = new System.Drawing.Size(120, 79);
            this.ListBoxHistory.TabIndex = 20;
            // 
            // LabelTest
            // 
            this.LabelTest.AutoSize = true;
            this.LabelTest.Location = new System.Drawing.Point(12, 425);
            this.LabelTest.Name = "LabelTest";
            this.LabelTest.Size = new System.Drawing.Size(54, 25);
            this.LabelTest.TabIndex = 21;
            this.LabelTest.Text = "Test";
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 716);
            this.Controls.Add(this.LabelTest);
            this.Controls.Add(this.ListBoxHistory);
            this.Controls.Add(this.PictureBoxEnglish);
            this.Controls.Add(this.PictureBoxDutch);
            this.Controls.Add(this.RadioButtonEnglish);
            this.Controls.Add(this.RadioButtonDutch);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelStop);
            this.Controls.Add(this.LabelStart);
            this.Controls.Add(this.LabelMaterials);
            this.Controls.Add(this.ComboBoxMaterials);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form User";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxEnglish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxDutch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxMaterials;
        private System.Windows.Forms.Label LabelMaterials;
        private System.Windows.Forms.Label LabelStart;
        private System.Windows.Forms.Label LabelStop;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.RadioButton RadioButtonDutch;
        private System.Windows.Forms.RadioButton RadioButtonEnglish;
        private System.Windows.Forms.PictureBox PictureBoxDutch;
        private System.Windows.Forms.PictureBox PictureBoxEnglish;
        private System.Windows.Forms.ListBox ListBoxHistory;
        private System.Windows.Forms.Label LabelTest;
    }
}

