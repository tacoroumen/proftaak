namespace SQL_server_DB_reader
{
    partial class ChooseUpload
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
            this.DataInsertLabel = new System.Windows.Forms.Label();
            this.MqttButton = new System.Windows.Forms.Button();
            this.SqlButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataInsertLabel
            // 
            this.DataInsertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.DataInsertLabel.Location = new System.Drawing.Point(-8, 9);
            this.DataInsertLabel.Name = "DataInsertLabel";
            this.DataInsertLabel.Size = new System.Drawing.Size(460, 29);
            this.DataInsertLabel.TabIndex = 0;
            this.DataInsertLabel.Text = "Select data insert method";
            this.DataInsertLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MqttButton
            // 
            this.MqttButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.MqttButton.Location = new System.Drawing.Point(293, 61);
            this.MqttButton.Name = "MqttButton";
            this.MqttButton.Size = new System.Drawing.Size(75, 30);
            this.MqttButton.TabIndex = 1;
            this.MqttButton.Text = "Mqtt";
            this.MqttButton.UseVisualStyleBackColor = true;
            this.MqttButton.Click += new System.EventHandler(this.MqttButton_Click);
            // 
            // SqlButton
            // 
            this.SqlButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SqlButton.Location = new System.Drawing.Point(67, 61);
            this.SqlButton.Name = "SqlButton";
            this.SqlButton.Size = new System.Drawing.Size(75, 30);
            this.SqlButton.TabIndex = 2;
            this.SqlButton.Text = "Sql";
            this.SqlButton.UseVisualStyleBackColor = true;
            this.SqlButton.Click += new System.EventHandler(this.SqlButton_Click);
            // 
            // ChooseUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 103);
            this.Controls.Add(this.SqlButton);
            this.Controls.Add(this.MqttButton);
            this.Controls.Add(this.DataInsertLabel);
            this.Name = "ChooseUpload";
            this.Text = "ChooseUpload";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DataInsertLabel;
        private System.Windows.Forms.Button MqttButton;
        private System.Windows.Forms.Button SqlButton;
    }
}