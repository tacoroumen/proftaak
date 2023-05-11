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
using System.Runtime.ExceptionServices;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Application = System.Windows.Forms.Application;

namespace SQL_server_DB_reader
{
    public partial class Login : Form
    {
        string[] ConString = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public Login()
        {
            InitializeComponent();

            ServerTextBox.Text = CaesarCipher(File.ReadAllText(@"DataFiles/Login/Server.txt"), false);
            DatabaseTextBox.Text = CaesarCipher(File.ReadAllText(@"DataFiles/Login/Database.txt"), false);
            UsernameTextBox.Text = CaesarCipher(File.ReadAllText(@"DataFiles/Login/Username.txt"), false);
            PasswordTextBox.Text = CaesarCipher(File.ReadAllText(@"DataFiles/Login/Password.txt"), false);

            if (File.ReadAllText(@"DataFiles/login/SaveLogin.txt") == "y")
            {
                SaveLoginCheckBox.Checked = true;
            }
        }

        private void AnalyzeButton_Click(object sender, EventArgs e)
        {
            UpdateConString();

            UpdateLoginDetails();

            if (VerifyLogin()) {
                Visualizer form2 = new Visualizer(ConString);
                form2.ShowDialog();
            }
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            UpdateConString();

            UpdateLoginDetails();

            if (VerifyLogin())
            {
                ChooseUpload form3 = new ChooseUpload();
                form3.ShowDialog();
            }
        }

        private void DisclaimerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" +
                "1. Application only works on MS SQL servers. \n" +
                "2. Most likely needs a port. \n" +
                "3. You can change the DB later but its needed for a connection.\n" +
                "4. All inputs are encrypted but not well so be carefull when sharing ur files.", 
                "Disclaimers and Info");
        }

        private void ForgetLoginButton_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"DataFiles/Login/Server.txt", "");
            File.WriteAllText(@"DataFiles/Login/Database.txt", "");
            File.WriteAllText(@"DataFiles/Login/Username.txt", "");
            File.WriteAllText(@"DataFiles/Login/Password.txt", "");

            File.WriteAllText(@"DataFiles/Login/SaveLogin.txt", "n");

            ServerTextBox.Text = "";
            DatabaseTextBox.Text = "";
            UsernameTextBox.Text = "";
            PasswordTextBox.Text = "";

            SaveLoginCheckBox.Checked = false;
        }

        string CaesarCipher(string input, bool encrypt)
        {
            string order = "wGho+[iYyZ>?JDU8}<fI&Frqx6Ov,A9a5lnp]2bjM|:z7QC.~`mgK4@^ENu()_WXTt-eV#$%H0/{ck1PL=SB!dRs3*'";  // exlcuding ; / and "  default caesar ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-=_+[]',./{}|:<>?~`
            string output = "";
            if (encrypt)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    bool fail = true;
                    for (int j = 0; j < order.Length; j++)
                    {
                        if (input[i] == order[j])
                        {
                            if (j < order.Length - 1)
                            {
                                output = output + order[j + 1];
                                fail = false;
                            }
                            else if (j == order.Length - 1)
                            {
                                output = output + order[0];
                                fail = false;
                            }
                        }
                    }
                    if (fail)
                    {
                        output = output + input[i];
                    }
                }
            }
            else if (!encrypt)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    bool fail = true;
                    for (int j = 0; j < order.Length; j++)
                    {
                        if (input[i] == order[j])
                        {
                            if (j > 0)
                            {
                                output = output + order[j - 1];
                                fail = false;
                            }
                            else if (j == 0)
                            {
                                output = output + order[order.Length - 1];
                                fail = false;
                            }
                        }
                    }
                    if (fail)
                    {
                        output = output + input[i];
                    }
                }
            }
            return output;
        }

        string ConStringFull(string[] input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                output = output + input[i];
            }
            return output;
        }

        bool VerifyLogin()
        {
            SqlConnection conn = new SqlConnection(ConStringFull(ConString));
            bool login = true;
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                login = false;
                MessageBox.Show("Couldn't verify login, Not saving.\nError message:\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }

            return login;
        }

        void UpdateConString()
        {
            string SecuInfo = "";
            if (SaveLoginCheckBox.Checked)
            {
                SecuInfo = "True";
            }
            else
            {
                SecuInfo = "False";
            }

            ConString[0] = "Data Source=";
            ConString[1] = ServerTextBox.Text;
            ConString[2] = ";Initial Catalog=";
            ConString[3] = DatabaseTextBox.Text;
            ConString[4] = ";Persist Security Info=";
            ConString[5] = SecuInfo;
            ConString[6] = ";User ID=";
            ConString[7] = UsernameTextBox.Text;
            ConString[8] = ";Password=";
            ConString[9] = PasswordTextBox.Text;
        }

        void UpdateLoginDetails()
        {
            if (SaveLoginCheckBox.Checked)
            {
                if (VerifyLogin())
                {
                    File.WriteAllText(@"DataFiles/Login/Server.txt", CaesarCipher(ServerTextBox.Text, true));
                    File.WriteAllText(@"DataFiles/Login/Database.txt", CaesarCipher(DatabaseTextBox.Text, true));
                    File.WriteAllText(@"DataFiles/Login/Username.txt", CaesarCipher(UsernameTextBox.Text, true));
                    File.WriteAllText(@"DataFiles/Login/Password.txt", CaesarCipher(PasswordTextBox.Text, true));
                }

                File.WriteAllText(@"DataFiles/Login/SaveLogin.txt", "y");
            }
            else if (!SaveLoginCheckBox.Checked)
            {
                File.WriteAllText(@"DataFiles/Login/SaveLogin.txt", "n");
            }
        }

    }
}
