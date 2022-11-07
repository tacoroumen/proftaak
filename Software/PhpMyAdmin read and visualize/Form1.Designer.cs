namespace PhpMyAdmin_read_and_visualize
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
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SaveLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.ForgetLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.Location = new System.Drawing.Point(114, 95);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(75, 23);
            this.AnalyzeButton.TabIndex = 0;
            this.AnalyzeButton.Text = "Analyze";
            this.AnalyzeButton.UseVisualStyleBackColor = true;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(88, 9);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(100, 22);
            this.ServerTextBox.TabIndex = 1;
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(12, 9);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(47, 16);
            this.ServerLabel.TabIndex = 2;
            this.ServerLabel.Text = "Server";
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(12, 31);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(67, 16);
            this.DatabaseLabel.TabIndex = 3;
            this.DatabaseLabel.Text = "Database";
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(88, 28);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(100, 22);
            this.DatabaseTextBox.TabIndex = 4;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(88, 47);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(100, 22);
            this.UsernameTextBox.TabIndex = 5;
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(12, 50);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 16);
            this.UsernameLabel.TabIndex = 6;
            this.UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 69);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 7;
            this.PasswordLabel.Text = "Password";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(88, 66);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(100, 22);
            this.PasswordTextBox.TabIndex = 8;
            // 
            // SaveLoginCheckBox
            // 
            this.SaveLoginCheckBox.AutoSize = true;
            this.SaveLoginCheckBox.Location = new System.Drawing.Point(12, 97);
            this.SaveLoginCheckBox.Name = "SaveLoginCheckBox";
            this.SaveLoginCheckBox.Size = new System.Drawing.Size(93, 20);
            this.SaveLoginCheckBox.TabIndex = 9;
            this.SaveLoginCheckBox.Text = "Save login";
            this.SaveLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // ForgetLoginButton
            // 
            this.ForgetLoginButton.Location = new System.Drawing.Point(12, 123);
            this.ForgetLoginButton.Name = "ForgetLoginButton";
            this.ForgetLoginButton.Size = new System.Drawing.Size(100, 25);
            this.ForgetLoginButton.TabIndex = 10;
            this.ForgetLoginButton.Text = "Forget login";
            this.ForgetLoginButton.UseVisualStyleBackColor = true;
            this.ForgetLoginButton.Click += new System.EventHandler(this.ForgetLoginButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(201, 152);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.ForgetLoginButton);
            this.Controls.Add(this.SaveLoginCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.ServerTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.CheckBox SaveLoginCheckBox;
        private System.Windows.Forms.Button ForgetLoginButton;
    }
}

