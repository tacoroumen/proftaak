namespace PhpMyAdmin_read_and_visualize
{
    partial class NotSavedNotification
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
            this.label1 = new System.Windows.Forms.Label();
            this.SaveAnywaysButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Due to not being able to verify this login it wont be saved for further launches." +
    "";
            // 
            // SaveAnywaysButton
            // 
            this.SaveAnywaysButton.Location = new System.Drawing.Point(138, 63);
            this.SaveAnywaysButton.Name = "SaveAnywaysButton";
            this.SaveAnywaysButton.Size = new System.Drawing.Size(113, 23);
            this.SaveAnywaysButton.TabIndex = 1;
            this.SaveAnywaysButton.Text = "Save Anyways";
            this.SaveAnywaysButton.UseVisualStyleBackColor = true;
            this.SaveAnywaysButton.Visible = false;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(279, 63);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Okay";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "The previous login data will be used instead.";
            // 
            // NotSavedNotification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 99);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.SaveAnywaysButton);
            this.Controls.Add(this.label1);
            this.Name = "NotSavedNotification";
            this.Text = "New Notification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveAnywaysButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label label2;
    }
}