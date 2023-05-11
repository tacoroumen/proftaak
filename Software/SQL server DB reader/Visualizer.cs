using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SQL_server_DB_reader
{
    public partial class Visualizer : Form
    {
        string[] ConString = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public Visualizer(string[] ConStringParse)
        {
            InitializeComponent();

            ConString = ConStringParse;

            SqlConnection conn = new SqlConnection(ConStringFull());
            conn.Open();
            string query = "SELECT name FROM sys.databases";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                DatabaseComboBox.Items.Add(reader["name"]);
            }
            conn.Close();

            TableComboBoxUpdate();

            int location = 0;

            for (int i = 0; i < DatabaseComboBox.Items.Count; i++)
            {
                if (ConString[3] == DatabaseComboBox.Items[i].ToString())
                {
                    location = i;
                    break;
                }
            }

            DatabaseComboBox.SelectedIndex = location;

            SQLCommandRichTextBox.Text = "SELECT *\nFROM ";
        }

        string ConStringFull()
        {
            string ConStringFull = "";
            for (int i = 0; i < ConString.Length; i++)
            {
                ConStringFull = ConStringFull + ConString[i];
            }
            return ConStringFull;
        }

        private void DatabaseComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ConString[3] != DatabaseComboBox.Text)
            {
                CollumCheckedListBox.Items.Clear();
                TableComboBox.Text = "";
            }
            ConString[3] = DatabaseComboBox.Text;

            TableComboBoxUpdate();
        }

        void TableComboBoxUpdate()
        {
            TableComboBox.Items.Clear();

            SqlConnection conn = new SqlConnection(ConStringFull());
            conn.Open();
            string query = "SELECT * FROM SYSOBJECTS WHERE xtype = 'U'";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                TableComboBox.Items.Add(reader["name"]);
            }
            conn.Close();
        }

        private void TableComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            CollumCheckedListBox.Items.Clear();
            CollumCheckedListBox.Items.Add("All");
            SqlConnection conn = new SqlConnection(ConStringFull());
            conn.Open();
            string query = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo." + TableComboBox.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CollumCheckedListBox.Items.Add(reader["name"]);
            }
            conn.Close();

            UpdateVisuals("SELECT *\nFROM " + TableComboBox.Text, true);
        }

        private void CmdUpdateButton_Click(object sender, EventArgs e)
        {
            string StringBuild = "";

            var CheckedListBoxContent = new List<string>();
            CheckedListBoxContent.Add("*");
            SqlConnection conn = new SqlConnection(ConStringFull());
            conn.Open();
            string query = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + TableComboBox.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                CheckedListBoxContent.Add((string)reader["name"]);
            }
            conn.Close();

            var locations = new List<int>();
            for (int i = 0; i <= (CollumCheckedListBox.Items.Count - 1); i++)
            {
                if (CollumCheckedListBox.GetItemChecked(i))
                {
                    locations.Add(i);
                }
            }


            StringBuild += "SELECT";
            bool first = true;
            try
            {
                if (locations[0] == 0)
                {
                    StringBuild += " *";
                }
                else
                {
                    for (int i = 0; i < locations.Count; i++)
                    {
                        if (first)
                        {
                            StringBuild += " " + CheckedListBoxContent[locations[i]];
                            first = false;
                        }
                        else
                        {
                            StringBuild += ", " + CheckedListBoxContent[locations[i]];
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("You most likely didnt fill in all the boxes. \nError message:\n" + ex.Message);
            }
            StringBuild += " ";

            StringBuild += "\n";

            StringBuild += "FROM " + TableComboBox.Text;



            SQLCommandRichTextBox.Text = StringBuild;
        }

        private void UpdateOutputButton_Click(object sender, EventArgs e)
        {
            string query = SQLCommandRichTextBox.Text;

            UpdateVisuals(query, false);
        }

        void UpdateVisuals(string query0, bool firstload)
        {
            QuerryOutputDataGridView.DataSource = null;
            var locations = new List<int>();
            if (!firstload)
            {
                for (int i = 0; i <= (CollumCheckedListBox.Items.Count - 1); i++)
                {
                    if (CollumCheckedListBox.GetItemChecked(i))
                    {
                        locations.Add(i);
                    }
                }
            }
            else
            {
                locations.Add(0);
            }

            var CheckedListBoxContent = new List<string>();
            CheckedListBoxContent.Add("*");
            SqlConnection conn1 = new SqlConnection(ConStringFull());
            conn1.Open();
            string query1 = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + TableComboBox.Text + "')";
            SqlCommand cmd1 = new SqlCommand(query1, conn1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            while (reader1.Read())
            {
                CheckedListBoxContent.Add((string)reader1["name"]);
            }
            conn1.Close();

            var UsedColloms = new List<string>();
            try
            {
                if (locations[0] == 0)
                {
                    SqlConnection conn2 = new SqlConnection(ConStringFull());
                    conn2.Open();
                    string query2 = "SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('" + TableComboBox.Text + "')";
                    SqlCommand cmd2 = new SqlCommand(query2, conn2);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    while (reader2.Read())
                    {
                        UsedColloms.Add((string)reader2["name"]);
                    }
                    conn2.Close();
                }
                else
                {
                    for (int i = 0; i < locations.Count; i++)
                    {

                        UsedColloms.Add(CheckedListBoxContent[locations[i]]);
                    }
                }

                if (UsedColloms[0] == "*")
                {
                    QuerryOutputDataGridView.ColumnCount = CheckedListBoxContent.Count - 1;

                    for (int i = 0; i < CheckedListBoxContent.Count - 1; i++)
                    {
                        QuerryOutputDataGridView.Columns[i].Name = CheckedListBoxContent[i + 1];
                        QuerryOutputDataGridView.Columns[i].DisplayIndex = i;
                    }
                }
                else
                {
                    QuerryOutputDataGridView.ColumnCount = UsedColloms.Count;
                    int i = 0;
                    foreach (string collom in UsedColloms)
                    {
                        QuerryOutputDataGridView.Columns[i].Name = collom;
                        QuerryOutputDataGridView.Columns[i].DisplayIndex = i;
                        i++;
                    }
                }

                if (firstload)
                {
                    QuerryOutputDataGridView.Rows.Clear();
                    SqlConnection conn3 = new SqlConnection(ConStringFull());
                    conn3.Open();
                    string query3 = "SELECT * FROM " + TableComboBox.Text;
                    SqlCommand cmd3 = new SqlCommand(query3, conn3);
                    SqlDataReader reader3 = cmd3.ExecuteReader();
                    while (reader3.Read())
                    {
                        int i = 0;
                        string[] row = new string[UsedColloms.Count];
                        i = 0;
                        for (i = 0; i < UsedColloms.Count; i++)
                        {
                            string chace = reader3[UsedColloms[i]].ToString();
                            row[i] = chace;
                        }

                        string[] RowFull = new string[UsedColloms.Count];
                        i = 0;
                        foreach (string item in row)
                        {
                            RowFull[i] = item;
                            i++;
                        }
                        QuerryOutputDataGridView.Rows.Add(RowFull);
                    }
                    conn3.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("You most likely didnt fill in all the boxes. \nError message:\n" + ex.Message);
            }

            if (!firstload)
            {
                try
                {
                    QuerryOutputDataGridView.Rows.Clear();
                    SqlConnection conn0 = new SqlConnection(ConStringFull());
                    conn0.Open();
                    SqlCommand cmd0 = new SqlCommand(query0, conn0);
                    SqlDataReader reader0 = cmd0.ExecuteReader();
                    while (reader0.Read())
                    {
                        string[] row = new string[UsedColloms.Count];
                        int i;
                        for (i = 0; i < UsedColloms.Count; i++)
                        {
                            string chace = reader0[UsedColloms[i]].ToString();
                            row[i] = chace;
                        }

                        string[] RowFull = new string[UsedColloms.Count];
                        i = 0;
                        foreach (string item in row)
                        {
                            RowFull[i] = item;
                            i++;
                        }
                        QuerryOutputDataGridView.Rows.Add(RowFull);
                    }
                    conn0.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Click Cmd Update.\nIf this didnt fix it you most likely didnt fill in all the boxes or gave a bad query. \nError message:\n" + ex.Message);
                }

            }
        }
    }
}

