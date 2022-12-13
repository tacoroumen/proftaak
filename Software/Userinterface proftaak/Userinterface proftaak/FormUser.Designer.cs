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
            this.LabelStop = new System.Windows.Forms.Label();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.ListBoxHistory = new System.Windows.Forms.ListBox();
            this.LabelTest = new System.Windows.Forms.Label();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ComboBoxMaterials
            // 
            this.ComboBoxMaterials.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxMaterials.FormattingEnabled = true;
            this.ComboBoxMaterials.Items.AddRange(new object[] {
            "Paper",
            "Plastic",
            "General Waste"});
            this.ComboBoxMaterials.Location = new System.Drawing.Point(325, 275);
            this.ComboBoxMaterials.Name = "ComboBoxMaterials";
            this.ComboBoxMaterials.Size = new System.Drawing.Size(253, 33);
            this.ComboBoxMaterials.TabIndex = 0;
            this.ComboBoxMaterials.SelectedIndexChanged += new System.EventHandler(this.ComboBoxMaterials_SelectedIndexChanged);
            // 
            // LabelMaterials
            // 
            this.LabelMaterials.AutoSize = true;
            this.LabelMaterials.Location = new System.Drawing.Point(403, 247);
            this.LabelMaterials.Name = "LabelMaterials";
            this.LabelMaterials.Size = new System.Drawing.Size(101, 25);
            this.LabelMaterials.TabIndex = 1;
            this.LabelMaterials.Text = "Materiaal";
            // 
            // LabelStop
            // 
            this.LabelStop.AutoSize = true;
            this.LabelStop.Location = new System.Drawing.Point(370, 359);
            this.LabelStop.Name = "LabelStop";
            this.LabelStop.Size = new System.Drawing.Size(164, 25);
            this.LabelStop.TabIndex = 6;
            this.LabelStop.Text = "Beëindig sessie";
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(375, 387);
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
            this.LabelUsername.Location = new System.Drawing.Point(370, 134);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(170, 25);
            this.LabelUsername.TabIndex = 12;
            this.LabelUsername.Text = "Gebruikersnaam";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(325, 162);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.ReadOnly = true;
            this.TextBoxUsername.Size = new System.Drawing.Size(253, 31);
            this.TextBoxUsername.TabIndex = 13;
            // 
            // ListBoxHistory
            // 
            this.ListBoxHistory.FormattingEnabled = true;
            this.ListBoxHistory.ItemHeight = 25;
            this.ListBoxHistory.Location = new System.Drawing.Point(12, 121);
            this.ListBoxHistory.Name = "ListBoxHistory";
            this.ListBoxHistory.Size = new System.Drawing.Size(119, 279);
            this.ListBoxHistory.TabIndex = 20;
            // 
            // LabelTest
            // 
            this.LabelTest.AutoSize = true;
            this.LabelTest.Location = new System.Drawing.Point(12, 84);
            this.LabelTest.Name = "LabelTest";
            this.LabelTest.Size = new System.Drawing.Size(54, 25);
            this.LabelTest.TabIndex = 21;
            this.LabelTest.Text = "Test";
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(17, 414);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(185, 31);
            this.TextBoxWeight.TabIndex = 22;
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(17, 451);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(185, 31);
            this.TextBoxPrice.TabIndex = 23;
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 559);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.LabelTest);
            this.Controls.Add(this.ListBoxHistory);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.LabelStop);
            this.Controls.Add(this.LabelMaterials);
            this.Controls.Add(this.ComboBoxMaterials);
            this.Name = "FormUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form User";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxMaterials;
        private System.Windows.Forms.Label LabelMaterials;
        private System.Windows.Forms.Label LabelStop;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.ListBox ListBoxHistory;
        private System.Windows.Forms.Label LabelTest;
        private TextBox TextBoxWeight;
        private TextBox TextBoxPrice;
    }
}

