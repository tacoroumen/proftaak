namespace Userinterface_proftaak
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
            this.ComboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.LabelMaterials = new System.Windows.Forms.Label();
            this.LabelWeight = new System.Windows.Forms.Label();
            this.TextBoxWeight = new System.Windows.Forms.TextBox();
            this.LabelKG = new System.Windows.Forms.Label();
            this.LabelStart = new System.Windows.Forms.Label();
            this.LabelStop = new System.Windows.Forms.Label();
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.LabelPrice = new System.Windows.Forms.Label();
            this.TextBoxPrice = new System.Windows.Forms.TextBox();
            this.LabelEuro = new System.Windows.Forms.Label();
            this.LabelUsername = new System.Windows.Forms.Label();
            this.TextBoxUsername = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ComboBoxMaterials
            // 
            this.ComboBoxMaterials.FormattingEnabled = true;
            this.ComboBoxMaterials.Items.AddRange(new object[] {
            "a",
            "b",
            "c"});
            this.ComboBoxMaterials.Location = new System.Drawing.Point(879, 477);
            this.ComboBoxMaterials.Name = "ComboBoxMaterials";
            this.ComboBoxMaterials.Size = new System.Drawing.Size(239, 33);
            this.ComboBoxMaterials.TabIndex = 0;
            // 
            // LabelMaterials
            // 
            this.LabelMaterials.AutoSize = true;
            this.LabelMaterials.Location = new System.Drawing.Point(879, 449);
            this.LabelMaterials.Name = "LabelMaterials";
            this.LabelMaterials.Size = new System.Drawing.Size(190, 25);
            this.LabelMaterials.TabIndex = 1;
            this.LabelMaterials.Text = "Select the material";
            // 
            // LabelWeight
            // 
            this.LabelWeight.AutoSize = true;
            this.LabelWeight.Location = new System.Drawing.Point(879, 574);
            this.LabelWeight.Name = "LabelWeight";
            this.LabelWeight.Size = new System.Drawing.Size(85, 25);
            this.LabelWeight.TabIndex = 2;
            this.LabelWeight.Text = "Weight:";
            // 
            // TextBoxWeight
            // 
            this.TextBoxWeight.Location = new System.Drawing.Point(970, 574);
            this.TextBoxWeight.Name = "TextBoxWeight";
            this.TextBoxWeight.Size = new System.Drawing.Size(100, 31);
            this.TextBoxWeight.TabIndex = 3;
            // 
            // LabelKG
            // 
            this.LabelKG.AutoSize = true;
            this.LabelKG.Location = new System.Drawing.Point(1076, 574);
            this.LabelKG.Name = "LabelKG";
            this.LabelKG.Size = new System.Drawing.Size(38, 25);
            this.LabelKG.TabIndex = 4;
            this.LabelKG.Text = "Kg";
            // 
            // LabelStart
            // 
            this.LabelStart.AutoSize = true;
            this.LabelStart.Location = new System.Drawing.Point(193, 214);
            this.LabelStart.Name = "LabelStart";
            this.LabelStart.Size = new System.Drawing.Size(163, 25);
            this.LabelStart.TabIndex = 5;
            this.LabelStart.Text = "Start measuring";
            // 
            // LabelStop
            // 
            this.LabelStop.AutoSize = true;
            this.LabelStop.Location = new System.Drawing.Point(193, 556);
            this.LabelStop.Name = "LabelStop";
            this.LabelStop.Size = new System.Drawing.Size(162, 25);
            this.LabelStop.TabIndex = 6;
            this.LabelStop.Text = "Stop measuring";
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(198, 242);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(158, 89);
            this.ButtonStart.TabIndex = 7;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(198, 584);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(157, 85);
            this.ButtonStop.TabIndex = 8;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // LabelPrice
            // 
            this.LabelPrice.AutoSize = true;
            this.LabelPrice.Location = new System.Drawing.Point(879, 638);
            this.LabelPrice.Name = "LabelPrice";
            this.LabelPrice.Size = new System.Drawing.Size(61, 25);
            this.LabelPrice.TabIndex = 9;
            this.LabelPrice.Text = "Price";
            // 
            // TextBoxPrice
            // 
            this.TextBoxPrice.Location = new System.Drawing.Point(970, 638);
            this.TextBoxPrice.Name = "TextBoxPrice";
            this.TextBoxPrice.Size = new System.Drawing.Size(100, 31);
            this.TextBoxPrice.TabIndex = 10;
            // 
            // LabelEuro
            // 
            this.LabelEuro.AutoSize = true;
            this.LabelEuro.Location = new System.Drawing.Point(1076, 638);
            this.LabelEuro.Name = "LabelEuro";
            this.LabelEuro.Size = new System.Drawing.Size(57, 25);
            this.LabelEuro.TabIndex = 11;
            this.LabelEuro.Text = "Euro";
            // 
            // LabelUsername
            // 
            this.LabelUsername.AutoSize = true;
            this.LabelUsername.Location = new System.Drawing.Point(879, 214);
            this.LabelUsername.Name = "LabelUsername";
            this.LabelUsername.Size = new System.Drawing.Size(110, 25);
            this.LabelUsername.TabIndex = 12;
            this.LabelUsername.Text = "Username";
            // 
            // TextBoxUsername
            // 
            this.TextBoxUsername.Location = new System.Drawing.Point(879, 242);
            this.TextBoxUsername.Name = "TextBoxUsername";
            this.TextBoxUsername.Size = new System.Drawing.Size(150, 31);
            this.TextBoxUsername.TabIndex = 13;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(493, 277);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(284, 304);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 826);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.TextBoxUsername);
            this.Controls.Add(this.LabelUsername);
            this.Controls.Add(this.LabelEuro);
            this.Controls.Add(this.TextBoxPrice);
            this.Controls.Add(this.LabelPrice);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.Controls.Add(this.LabelStop);
            this.Controls.Add(this.LabelStart);
            this.Controls.Add(this.LabelKG);
            this.Controls.Add(this.TextBoxWeight);
            this.Controls.Add(this.LabelWeight);
            this.Controls.Add(this.LabelMaterials);
            this.Controls.Add(this.ComboBoxMaterials);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxMaterials;
        private System.Windows.Forms.Label LabelMaterials;
        private System.Windows.Forms.Label LabelWeight;
        private System.Windows.Forms.TextBox TextBoxWeight;
        private System.Windows.Forms.Label LabelKG;
        private System.Windows.Forms.Label LabelStart;
        private System.Windows.Forms.Label LabelStop;
        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Label LabelPrice;
        private System.Windows.Forms.TextBox TextBoxPrice;
        private System.Windows.Forms.Label LabelEuro;
        private System.Windows.Forms.Label LabelUsername;
        private System.Windows.Forms.TextBox TextBoxUsername;
        private System.Windows.Forms.ListBox listBox1;
    }
}

