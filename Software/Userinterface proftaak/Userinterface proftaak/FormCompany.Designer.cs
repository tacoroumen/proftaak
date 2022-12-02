namespace Userinterface_proftaak
{
    partial class FormCompany
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
            this.ProgressBarPaper = new System.Windows.Forms.ProgressBar();
            this.ProgressBarPlastic = new System.Windows.Forms.ProgressBar();
            this.ProgressBarWaste = new System.Windows.Forms.ProgressBar();
            this.LabelPaper = new System.Windows.Forms.Label();
            this.LabelPlastic = new System.Windows.Forms.Label();
            this.LabelWaste = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ProgressBarPaper
            // 
            this.ProgressBarPaper.Location = new System.Drawing.Point(291, 149);
            this.ProgressBarPaper.Name = "ProgressBarPaper";
            this.ProgressBarPaper.Size = new System.Drawing.Size(501, 63);
            this.ProgressBarPaper.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarPaper.TabIndex = 0;
            // 
            // ProgressBarPlastic
            // 
            this.ProgressBarPlastic.Location = new System.Drawing.Point(291, 302);
            this.ProgressBarPlastic.Name = "ProgressBarPlastic";
            this.ProgressBarPlastic.Size = new System.Drawing.Size(501, 63);
            this.ProgressBarPlastic.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarPlastic.TabIndex = 1;
            // 
            // ProgressBarWaste
            // 
            this.ProgressBarWaste.Location = new System.Drawing.Point(291, 455);
            this.ProgressBarWaste.Name = "ProgressBarWaste";
            this.ProgressBarWaste.Size = new System.Drawing.Size(501, 63);
            this.ProgressBarWaste.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.ProgressBarWaste.TabIndex = 2;
            // 
            // LabelPaper
            // 
            this.LabelPaper.AutoSize = true;
            this.LabelPaper.Location = new System.Drawing.Point(286, 121);
            this.LabelPaper.Name = "LabelPaper";
            this.LabelPaper.Size = new System.Drawing.Size(69, 25);
            this.LabelPaper.TabIndex = 3;
            this.LabelPaper.Text = "Paper";
            // 
            // LabelPlastic
            // 
            this.LabelPlastic.AutoSize = true;
            this.LabelPlastic.Location = new System.Drawing.Point(286, 274);
            this.LabelPlastic.Name = "LabelPlastic";
            this.LabelPlastic.Size = new System.Drawing.Size(76, 25);
            this.LabelPlastic.TabIndex = 4;
            this.LabelPlastic.Text = "Plastic";
            // 
            // LabelWaste
            // 
            this.LabelWaste.AutoSize = true;
            this.LabelWaste.Location = new System.Drawing.Point(286, 427);
            this.LabelWaste.Name = "LabelWaste";
            this.LabelWaste.Size = new System.Drawing.Size(158, 25);
            this.LabelWaste.TabIndex = 5;
            this.LabelWaste.Text = "Residual waste";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(286, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "0%";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "100%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(286, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "0%";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(286, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "0%";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(725, 521);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "100%";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(725, 368);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 25);
            this.label10.TabIndex = 15;
            this.label10.Text = "100%";
            // 
            // FormCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 768);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelWaste);
            this.Controls.Add(this.LabelPlastic);
            this.Controls.Add(this.LabelPaper);
            this.Controls.Add(this.ProgressBarWaste);
            this.Controls.Add(this.ProgressBarPlastic);
            this.Controls.Add(this.ProgressBarPaper);
            this.Name = "FormCompany";
            this.Text = "Form Company";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar ProgressBarPaper;
        private System.Windows.Forms.ProgressBar ProgressBarPlastic;
        private System.Windows.Forms.ProgressBar ProgressBarWaste;
        private System.Windows.Forms.Label LabelPaper;
        private System.Windows.Forms.Label LabelPlastic;
        private System.Windows.Forms.Label LabelWaste;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}