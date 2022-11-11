namespace SQL_server_DB_reader
{
    partial class Form2
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
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.TableLabel = new System.Windows.Forms.Label();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SQLCommandLabel = new System.Windows.Forms.Label();
            this.SQLCommandRichTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(9, 7);
            this.DatabaseLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(60, 15);
            this.DatabaseLabel.TabIndex = 2;
            this.DatabaseLabel.Text = "Database";
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(9, 47);
            this.TableLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(38, 15);
            this.TableLabel.TabIndex = 3;
            this.TableLabel.Text = "Table";
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Items.AddRange(new object[] {
            "test"});
            this.TableComboBox.Location = new System.Drawing.Point(10, 63);
            this.TableComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(173, 21);
            this.TableComboBox.TabIndex = 4;
            this.TableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableComboBox_SelectedIndexChanged);
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(9, 23);
            this.DatabaseTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(174, 20);
            this.DatabaseTextBox.TabIndex = 7;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(10, 341);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(63, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SQLCommandLabel
            // 
            this.SQLCommandLabel.AutoSize = true;
            this.SQLCommandLabel.Location = new System.Drawing.Point(9, 86);
            this.SQLCommandLabel.Name = "SQLCommandLabel";
            this.SQLCommandLabel.Size = new System.Drawing.Size(98, 15);
            this.SQLCommandLabel.TabIndex = 12;
            this.SQLCommandLabel.Text = "SQL Commands";
            // 
            // SQLCommandRichTextBox
            // 
            this.SQLCommandRichTextBox.Location = new System.Drawing.Point(9, 104);
            this.SQLCommandRichTextBox.Name = "SQLCommandRichTextBox";
            this.SQLCommandRichTextBox.Size = new System.Drawing.Size(174, 232);
            this.SQLCommandRichTextBox.TabIndex = 11;
            this.SQLCommandRichTextBox.Text = "SELECT *\nFROM ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.SQLCommandLabel);
            this.Controls.Add(this.SQLCommandRichTextBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.DatabaseLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Data Visualizer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label SQLCommandLabel;
        private System.Windows.Forms.RichTextBox SQLCommandRichTextBox;
    }
}