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
            this.components = new System.ComponentModel.Container();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.UpdateOutputButton = new System.Windows.Forms.Button();
            this.SQLCommandLabel = new System.Windows.Forms.Label();
            this.SQLCommandRichTextBox = new System.Windows.Forms.RichTextBox();
            this.DatabaseComboBox = new System.Windows.Forms.ComboBox();
            this.QuerryOutputLabel = new System.Windows.Forms.Label();
            this.proftaakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maindbDataSet = new SQL_server_DB_reader.maindbDataSet();
            this.proftaakTableAdapter = new SQL_server_DB_reader.maindbDataSetTableAdapters.proftaakTableAdapter();
            this.QuerryOutputDataGridView = new System.Windows.Forms.DataGridView();
            this.TableLabel = new System.Windows.Forms.Label();
            this.TableComboBox = new System.Windows.Forms.ComboBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.CollumLabel = new System.Windows.Forms.Label();
            this.CollumCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.CmdUpdateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.proftaakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuerryOutputDataGridView)).BeginInit();
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
            // UpdateOutputButton
            // 
            this.UpdateOutputButton.Location = new System.Drawing.Point(125, 650);
            this.UpdateOutputButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateOutputButton.Name = "UpdateOutputButton";
            this.UpdateOutputButton.Size = new System.Drawing.Size(117, 28);
            this.UpdateOutputButton.TabIndex = 8;
            this.UpdateOutputButton.Text = "Update Output";
            this.UpdateOutputButton.UseVisualStyleBackColor = true;
            this.UpdateOutputButton.Click += new System.EventHandler(this.UpdateOutputButton_Click);
            // 
            // SQLCommandLabel
            // 
            this.SQLCommandLabel.AutoSize = true;
            this.SQLCommandLabel.Location = new System.Drawing.Point(8, 223);
            this.SQLCommandLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SQLCommandLabel.Name = "SQLCommandLabel";
            this.SQLCommandLabel.Size = new System.Drawing.Size(98, 16);
            this.SQLCommandLabel.TabIndex = 12;
            this.SQLCommandLabel.Text = "SQL Command";
            // 
            // SQLCommandRichTextBox
            // 
            this.SQLCommandRichTextBox.Location = new System.Drawing.Point(12, 242);
            this.SQLCommandRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SQLCommandRichTextBox.Name = "SQLCommandRichTextBox";
            this.SQLCommandRichTextBox.Size = new System.Drawing.Size(231, 367);
            this.SQLCommandRichTextBox.TabIndex = 11;
            this.SQLCommandRichTextBox.Text = "SELECT *\nFROM ";
            // 
            // DatabaseComboBox
            // 
            this.DatabaseComboBox.FormattingEnabled = true;
            this.DatabaseComboBox.Location = new System.Drawing.Point(12, 31);
            this.DatabaseComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DatabaseComboBox.Name = "DatabaseComboBox";
            this.DatabaseComboBox.Size = new System.Drawing.Size(231, 24);
            this.DatabaseComboBox.TabIndex = 13;
            this.DatabaseComboBox.SelectedIndexChanged += new System.EventHandler(this.DatabaseComboBox_SelectedIndexChanged);
            // 
            // QuerryOutputLabel
            // 
            this.QuerryOutputLabel.AutoSize = true;
            this.QuerryOutputLabel.Location = new System.Drawing.Point(251, 9);
            this.QuerryOutputLabel.Name = "QuerryOutputLabel";
            this.QuerryOutputLabel.Size = new System.Drawing.Size(88, 16);
            this.QuerryOutputLabel.TabIndex = 15;
            this.QuerryOutputLabel.Text = "Querry Output";
            // 
            // proftaakBindingSource
            // 
            this.proftaakBindingSource.DataMember = "proftaak";
            this.proftaakBindingSource.DataSource = this.maindbDataSet;
            // 
            // maindbDataSet
            // 
            this.maindbDataSet.DataSetName = "maindbDataSet";
            this.maindbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proftaakTableAdapter
            // 
            this.proftaakTableAdapter.ClearBeforeFill = true;
            // 
            // QuerryOutputDataGridView
            // 
            this.QuerryOutputDataGridView.AllowUserToAddRows = false;
            this.QuerryOutputDataGridView.AllowUserToDeleteRows = false;
            this.QuerryOutputDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuerryOutputDataGridView.Location = new System.Drawing.Point(253, 31);
            this.QuerryOutputDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.QuerryOutputDataGridView.Name = "QuerryOutputDataGridView";
            this.QuerryOutputDataGridView.ReadOnly = true;
            this.QuerryOutputDataGridView.RowHeadersWidth = 51;
            this.QuerryOutputDataGridView.RowTemplate.Height = 24;
            this.QuerryOutputDataGridView.ShowEditingIcon = false;
            this.QuerryOutputDataGridView.Size = new System.Drawing.Size(777, 646);
            this.QuerryOutputDataGridView.TabIndex = 16;
            // 
            // TableLabel
            // 
            this.TableLabel.AutoSize = true;
            this.TableLabel.Location = new System.Drawing.Point(12, 58);
            this.TableLabel.Name = "TableLabel";
            this.TableLabel.Size = new System.Drawing.Size(43, 16);
            this.TableLabel.TabIndex = 17;
            this.TableLabel.Text = "Table";
            // 
            // TableComboBox
            // 
            this.TableComboBox.FormattingEnabled = true;
            this.TableComboBox.Location = new System.Drawing.Point(12, 78);
            this.TableComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TableComboBox.Name = "TableComboBox";
            this.TableComboBox.Size = new System.Drawing.Size(231, 24);
            this.TableComboBox.TabIndex = 18;
            this.TableComboBox.SelectedIndexChanged += new System.EventHandler(this.TableComboBox_SelectedIndexChanged);
            // 
            // WarningLabel
            // 
            this.WarningLabel.BackColor = System.Drawing.Color.Red;
            this.WarningLabel.ForeColor = System.Drawing.Color.Black;
            this.WarningLabel.Location = new System.Drawing.Point(12, 614);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(229, 32);
            this.WarningLabel.TabIndex = 19;
            this.WarningLabel.Text = "Fill out all the boxes in order!!\nDont edit the first 2 lines!!";
            this.WarningLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CollumLabel
            // 
            this.CollumLabel.AutoSize = true;
            this.CollumLabel.Location = new System.Drawing.Point(12, 103);
            this.CollumLabel.Name = "CollumLabel";
            this.CollumLabel.Size = new System.Drawing.Size(48, 16);
            this.CollumLabel.TabIndex = 20;
            this.CollumLabel.Text = "Collum";
            // 
            // CollumCheckedListBox
            // 
            this.CollumCheckedListBox.FormattingEnabled = true;
            this.CollumCheckedListBox.Location = new System.Drawing.Point(12, 123);
            this.CollumCheckedListBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CollumCheckedListBox.Name = "CollumCheckedListBox";
            this.CollumCheckedListBox.Size = new System.Drawing.Size(231, 89);
            this.CollumCheckedListBox.TabIndex = 21;
            // 
            // CmdUpdateButton
            // 
            this.CmdUpdateButton.Location = new System.Drawing.Point(12, 650);
            this.CmdUpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CmdUpdateButton.Name = "CmdUpdateButton";
            this.CmdUpdateButton.Size = new System.Drawing.Size(99, 28);
            this.CmdUpdateButton.TabIndex = 22;
            this.CmdUpdateButton.Text = "Cmd Update";
            this.CmdUpdateButton.UseVisualStyleBackColor = true;
            this.CmdUpdateButton.Click += new System.EventHandler(this.CmdUpdateButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.CmdUpdateButton);
            this.Controls.Add(this.CollumCheckedListBox);
            this.Controls.Add(this.CollumLabel);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.TableComboBox);
            this.Controls.Add(this.TableLabel);
            this.Controls.Add(this.QuerryOutputDataGridView);
            this.Controls.Add(this.QuerryOutputLabel);
            this.Controls.Add(this.DatabaseComboBox);
            this.Controls.Add(this.SQLCommandLabel);
            this.Controls.Add(this.SQLCommandRichTextBox);
            this.Controls.Add(this.UpdateOutputButton);
            this.Controls.Add(this.DatabaseLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Data Visualizer";
            ((System.ComponentModel.ISupportInitialize)(this.proftaakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuerryOutputDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label DatabaseLabel;
        private System.Windows.Forms.Button UpdateOutputButton;
        private System.Windows.Forms.Label SQLCommandLabel;
        private System.Windows.Forms.RichTextBox SQLCommandRichTextBox;
        private System.Windows.Forms.ComboBox DatabaseComboBox;
        private System.Windows.Forms.Label QuerryOutputLabel;
        private maindbDataSet maindbDataSet;
        private System.Windows.Forms.BindingSource proftaakBindingSource;
        private maindbDataSetTableAdapters.proftaakTableAdapter proftaakTableAdapter;
        private System.Windows.Forms.DataGridView QuerryOutputDataGridView;
        private System.Windows.Forms.Label TableLabel;
        private System.Windows.Forms.ComboBox TableComboBox;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.Label CollumLabel;
        private System.Windows.Forms.CheckedListBox CollumCheckedListBox;
        private System.Windows.Forms.Button CmdUpdateButton;
    }
}