namespace SQL_server_DB_reader
{
    partial class SqlInsert
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlInsert));
            this.SqlCommandRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SqlCommandLabel = new System.Windows.Forms.Label();
            this.SqlFeedbackLabel = new System.Windows.Forms.Label();
            this.SQlFeedbackRichTextBox = new System.Windows.Forms.RichTextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UsernameTextBox = new System.Windows.Forms.TextBox();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SaveLoginCheckBox = new System.Windows.Forms.CheckBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.ServerLabel = new System.Windows.Forms.Label();
            this.ServerTextBox = new System.Windows.Forms.TextBox();
            this.ViewFullTableDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewFullTableComboBox = new System.Windows.Forms.ComboBox();
            this.ViewFullTableLabel = new System.Windows.Forms.Label();
            this.CatFillerPictureBox = new System.Windows.Forms.PictureBox();
            this.RunCommandButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ViewFullTableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatFillerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // SqlCommandRichTextBox
            // 
            this.SqlCommandRichTextBox.Location = new System.Drawing.Point(12, 28);
            this.SqlCommandRichTextBox.Name = "SqlCommandRichTextBox";
            this.SqlCommandRichTextBox.Size = new System.Drawing.Size(243, 381);
            this.SqlCommandRichTextBox.TabIndex = 0;
            this.SqlCommandRichTextBox.Text = "";
            // 
            // SqlCommandLabel
            // 
            this.SqlCommandLabel.AutoSize = true;
            this.SqlCommandLabel.Location = new System.Drawing.Point(9, 7);
            this.SqlCommandLabel.Name = "SqlCommandLabel";
            this.SqlCommandLabel.Size = new System.Drawing.Size(92, 16);
            this.SqlCommandLabel.TabIndex = 1;
            this.SqlCommandLabel.Text = "Sql Command";
            // 
            // SqlFeedbackLabel
            // 
            this.SqlFeedbackLabel.AutoSize = true;
            this.SqlFeedbackLabel.Location = new System.Drawing.Point(258, 9);
            this.SqlFeedbackLabel.Name = "SqlFeedbackLabel";
            this.SqlFeedbackLabel.Size = new System.Drawing.Size(131, 16);
            this.SqlFeedbackLabel.TabIndex = 2;
            this.SqlFeedbackLabel.Text = "Sql Command output";
            // 
            // SQlFeedbackRichTextBox
            // 
            this.SQlFeedbackRichTextBox.Location = new System.Drawing.Point(261, 28);
            this.SQlFeedbackRichTextBox.Name = "SQlFeedbackRichTextBox";
            this.SQlFeedbackRichTextBox.Size = new System.Drawing.Size(319, 149);
            this.SQlFeedbackRichTextBox.TabIndex = 3;
            this.SQlFeedbackRichTextBox.Text = "Not fully functional \nOnly displays success/fail at this moment in time";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(671, 95);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(117, 22);
            this.PasswordTextBox.TabIndex = 18;
            // 
            // UsernameTextBox
            // 
            this.UsernameTextBox.Location = new System.Drawing.Point(671, 66);
            this.UsernameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameTextBox.Name = "UsernameTextBox";
            this.UsernameTextBox.Size = new System.Drawing.Size(117, 22);
            this.UsernameTextBox.TabIndex = 15;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(671, 38);
            this.DatabaseTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(117, 22);
            this.DatabaseTextBox.TabIndex = 14;
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(671, 147);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(117, 31);
            this.LoginButton.TabIndex = 20;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SaveLoginCheckBox
            // 
            this.SaveLoginCheckBox.Location = new System.Drawing.Point(671, 121);
            this.SaveLoginCheckBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveLoginCheckBox.Name = "SaveLoginCheckBox";
            this.SaveLoginCheckBox.Size = new System.Drawing.Size(117, 22);
            this.SaveLoginCheckBox.TabIndex = 19;
            this.SaveLoginCheckBox.Text = "Save login";
            this.SaveLoginCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveLoginCheckBox.UseVisualStyleBackColor = true;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(586, 93);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(67, 16);
            this.PasswordLabel.TabIndex = 17;
            this.PasswordLabel.Text = "Password";
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Location = new System.Drawing.Point(586, 66);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(70, 16);
            this.UsernameLabel.TabIndex = 16;
            this.UsernameLabel.Text = "Username";
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(586, 38);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(67, 16);
            this.DatabaseLabel.TabIndex = 13;
            this.DatabaseLabel.Text = "Database";
            // 
            // ServerLabel
            // 
            this.ServerLabel.AutoSize = true;
            this.ServerLabel.Location = new System.Drawing.Point(586, 14);
            this.ServerLabel.Name = "ServerLabel";
            this.ServerLabel.Size = new System.Drawing.Size(47, 16);
            this.ServerLabel.TabIndex = 12;
            this.ServerLabel.Text = "Server";
            // 
            // ServerTextBox
            // 
            this.ServerTextBox.Location = new System.Drawing.Point(671, 11);
            this.ServerTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServerTextBox.Name = "ServerTextBox";
            this.ServerTextBox.Size = new System.Drawing.Size(117, 22);
            this.ServerTextBox.TabIndex = 11;
            // 
            // ViewFullTableDataGridView
            // 
            this.ViewFullTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewFullTableDataGridView.Location = new System.Drawing.Point(261, 213);
            this.ViewFullTableDataGridView.Name = "ViewFullTableDataGridView";
            this.ViewFullTableDataGridView.RowHeadersWidth = 51;
            this.ViewFullTableDataGridView.RowTemplate.Height = 24;
            this.ViewFullTableDataGridView.Size = new System.Drawing.Size(527, 225);
            this.ViewFullTableDataGridView.TabIndex = 21;
            // 
            // ViewFullTableComboBox
            // 
            this.ViewFullTableComboBox.FormattingEnabled = true;
            this.ViewFullTableComboBox.Location = new System.Drawing.Point(294, 183);
            this.ViewFullTableComboBox.Name = "ViewFullTableComboBox";
            this.ViewFullTableComboBox.Size = new System.Drawing.Size(149, 24);
            this.ViewFullTableComboBox.TabIndex = 22;
            this.ViewFullTableComboBox.SelectedIndexChanged += new System.EventHandler(this.ViewFullTableComboBox_SelectedIndexChanged);
            // 
            // ViewFullTableLabel
            // 
            this.ViewFullTableLabel.AutoSize = true;
            this.ViewFullTableLabel.Location = new System.Drawing.Point(258, 186);
            this.ViewFullTableLabel.Name = "ViewFullTableLabel";
            this.ViewFullTableLabel.Size = new System.Drawing.Size(263, 16);
            this.ViewFullTableLabel.TabIndex = 23;
            this.ViewFullTableLabel.Text = "View ...................--------.................... in its entirety";
            // 
            // CatFillerPictureBox
            // 
            this.CatFillerPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("CatFillerPictureBox.Image")));
            this.CatFillerPictureBox.Location = new System.Drawing.Point(586, 112);
            this.CatFillerPictureBox.Name = "CatFillerPictureBox";
            this.CatFillerPictureBox.Size = new System.Drawing.Size(76, 65);
            this.CatFillerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CatFillerPictureBox.TabIndex = 24;
            this.CatFillerPictureBox.TabStop = false;
            // 
            // RunCommandButton
            // 
            this.RunCommandButton.Location = new System.Drawing.Point(12, 415);
            this.RunCommandButton.Name = "RunCommandButton";
            this.RunCommandButton.Size = new System.Drawing.Size(243, 23);
            this.RunCommandButton.TabIndex = 25;
            this.RunCommandButton.Text = "Run Command";
            this.RunCommandButton.UseVisualStyleBackColor = true;
            this.RunCommandButton.Click += new System.EventHandler(this.RunCommandButton_Click);
            // 
            // SqlInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunCommandButton);
            this.Controls.Add(this.CatFillerPictureBox);
            this.Controls.Add(this.ViewFullTableComboBox);
            this.Controls.Add(this.ViewFullTableDataGridView);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UsernameTextBox);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.SaveLoginCheckBox);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.DatabaseLabel);
            this.Controls.Add(this.ServerLabel);
            this.Controls.Add(this.ServerTextBox);
            this.Controls.Add(this.SQlFeedbackRichTextBox);
            this.Controls.Add(this.SqlFeedbackLabel);
            this.Controls.Add(this.SqlCommandLabel);
            this.Controls.Add(this.SqlCommandRichTextBox);
            this.Controls.Add(this.ViewFullTableLabel);
            this.Name = "SqlInsert";
            this.Text = "SqlInsert";
            ((System.ComponentModel.ISupportInitialize)(this.ViewFullTableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatFillerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox SqlCommandRichTextBox;
        private System.Windows.Forms.Label SqlCommandLabel;
        private System.Windows.Forms.Label SqlFeedbackLabel;
        private System.Windows.Forms.RichTextBox SQlFeedbackRichTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UsernameTextBox;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.CheckBox SaveLoginCheckBox;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Label ServerLabel;
        private System.Windows.Forms.TextBox ServerTextBox;
        private System.Windows.Forms.DataGridView ViewFullTableDataGridView;
        private System.Windows.Forms.ComboBox ViewFullTableComboBox;
        private System.Windows.Forms.Label ViewFullTableLabel;
        private System.Windows.Forms.PictureBox CatFillerPictureBox;
        private System.Windows.Forms.Button RunCommandButton;
    }
}