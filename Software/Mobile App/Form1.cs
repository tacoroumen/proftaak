using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace Mobile_App
{
    public partial class Startup : Form
    {
        public AddAccount AddAccount = new AddAccount();

        public void HideAllForms ()
        {
            this.Opacity = 0;
            AddAccount.Opacity = 0.00;
        }

        public Startup()
        {
            InitializeComponent();

            this.Location = new Point(50, 50);


            //int UserCount = int.Parse(File.ReadAllText(@"DataFiles/User/UserCount.txt"));
            //if (UserCount != 0)
            //{
            //    UpdateAccountList(UserCount);
            //}
        }

        private void TempFullscreen_Click(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        void UpdateAccountList(int UserCount)
        {
            for (int i = 0; i < UserCount; i++)
            {
                string username = File.ReadAllText($@"DataFiles/User/User{i}/Username{i}.txt");
                string password = File.ReadAllText($@"DataFiles/User/User{i}/Password{i}.txt");

                SqlConnection conn = new SqlConnection();
                conn.Open();
                string query = "SELECT username, email, type FROM users WHERE username = " + username + "AND password = " + password;
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    // username = Convert.ToString(reader["username"]);
                    string email = Convert.ToString(reader["email"]);
                    bool bussiness = Convert.ToBoolean(reader["type"]);
                }
                conn.Close();
            }
        }

        
        private void AddAccountButton_Click(object sender, EventArgs e)
        {
            AddAccount.ShowDialog();
        }

        private void ManageAccountsPictureBox_Click(object sender, EventArgs e)
        {
            if (0 != int.Parse(File.ReadAllText(@"DataFiles/User/UserCount.txt")))
            {
                //Form3 
            }
        }
    }
}