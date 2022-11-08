namespace PhpMyAdmin_read_and_visualize
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
            this.DataVisualizationLabel = new System.Windows.Forms.Label();
            this.DataVisualizationComboBox = new System.Windows.Forms.ComboBox();
            this.DatabaseTextBox = new System.Windows.Forms.TextBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.CollumCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CollumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.Location = new System.Drawing.Point(12, 9);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(67, 16);
            this.DatabaseLabel.TabIndex = 2;
            this.DatabaseLabel.Text = "Database";
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(12, 58);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(43, 16);
            this.TableLabel.TabIndex = 3;
            this.TableLabel.Text = "Table";
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Items.AddRange(new object[] {
            "test"});
            this.TableComboBox.Location = new System.Drawing.Point(13, 78);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(121, 24);
            this.TableComboBox.TabIndex = 4;
            this.TableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableComboBox_SelectedIndexChanged);
            // 
            // DataVisualizationLabel
            // 
            this.DataVisualizationLabel.AutoSize = true;
            this.DataVisualizationLabel.Location = new System.Drawing.Point(12, 216);
            this.DataVisualizationLabel.Name = "DataVisualizationLabel";
            this.DataVisualizationLabel.Size = new System.Drawing.Size(114, 16);
            this.DataVisualizationLabel.TabIndex = 5;
            this.DataVisualizationLabel.Text = "Data Visualization";
            // 
            // DataVisualizationComboBox
            // 
            this.DataVisualizationComboBox.FormattingEnabled = true;
            this.DataVisualizationComboBox.Location = new System.Drawing.Point(12, 236);
            this.DataVisualizationComboBox.Name = "DataVisualizationComboBox";
            this.DataVisualizationComboBox.Size = new System.Drawing.Size(121, 24);
            this.DataVisualizationComboBox.TabIndex = 6;
            // 
            // DatabaseTextBox
            // 
            this.DatabaseTextBox.Location = new System.Drawing.Point(12, 28);
            this.DatabaseTextBox.Name = "DatabaseTextBox";
            this.DatabaseTextBox.Size = new System.Drawing.Size(122, 22);
            this.DatabaseTextBox.TabIndex = 7;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(29, 266);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(84, 23);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // CollumCheckedListBox
            // 
            this.CollumCheckedListBox.FormattingEnabled = true;
            this.CollumCheckedListBox.Items.AddRange(new object[] {
            "None"});
            this.CollumCheckedListBox.Location = new System.Drawing.Point(12, 124);
            this.CollumCheckedListBox.Name = "CollumCheckedListBox";
            this.CollumCheckedListBox.Size = new System.Drawing.Size(120, 89);
            this.CollumCheckedListBox.TabIndex = 9;
            // 
            // CollumLabel
            // 
            this.CollumLabel.AutoSize = true;
            this.CollumLabel.Location = new System.Drawing.Point(12, 105);
            this.CollumLabel.Name = "CollumLabel";
            this.CollumLabel.Size = new System.Drawing.Size(48, 16);
            this.CollumLabel.TabIndex = 10;
            this.CollumLabel.Text = "Collum";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CollumLabel);
            this.Controls.Add(this.CollumCheckedListBox);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.DatabaseTextBox);
            this.Controls.Add(this.DataVisualizationComboBox);
            this.Controls.Add(this.DataVisualizationLabel);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.DatabaseLabel);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.Label DataVisualizationLabel;
        private System.Windows.Forms.ComboBox DataVisualizationComboBox;
        private System.Windows.Forms.TextBox DatabaseTextBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.CheckedListBox CollumCheckedListBox;
        private System.Windows.Forms.Label CollumLabel;
    }
}