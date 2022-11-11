using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhpMyAdmin_read_and_visualize
{
    public partial class DataVisualizer : Form
    {
        string[] ConString = { "", "", "", "", "", "", "", "", "", "", };
        public DataVisualizer()
        {
            InitializeComponent();

            using (Login form1 = new Login())
            {
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    ConString = form1.ConStringFetcher;
                }
            }

            string ConStringFull = "";
            for (int i = 0; i < ConString.Length; i++)
            {
                ConStringFull = ConStringFull + ConString[i];
            }

            MySqlConnection conn = new MySqlConnection(ConStringFull);
            conn.Open();
            string query = "SHOW TABLES FROM " + ConString[3];
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TableComboBox.Items.Add(reader["Tables_in_" + ConString[3]]);
            }
            conn.Close();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (DataVisualizationComboBox != null)
            {
                try
                {
                    // for string int etc
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Enter a data visualization method.");
            }
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (Login form1 = new Login())
            {
                if (form1.ShowDialog() == DialogResult.OK)
                {
                    ConString = form1.ConStringFetcher;
                }
            }

            string ConStringFull = "";
            for (int i = 0; i < ConString.Length; i++)
            {
                ConStringFull = ConStringFull + ConString[i];
            }

            MySqlConnection conn = new MySqlConnection(ConStringFull);
            conn.Open();
            string query = "DESCRIBE " + TableComboBox.Text;
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TableComboBox.Items.Add(reader["Field"]);
            }
            conn.Close();
        }
    }
}
