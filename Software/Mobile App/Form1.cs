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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            LoadCustomItems();

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


        //List<GroupBox> AccountGroupBoxes = new List<GroupBox>();
        //List<Label> UsernameLabels = new List<Label>();
        //List<Label> EmailLabels = new List<Label>();
        //List<PictureBox> AvatarPictures = new List<PictureBox>();
        //List<PictureBox> AccountTypePictures = new List<PictureBox>();


        void UpdateAccountList (int UserCount)
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

                GroupBox GrBox = new GroupBox();
                GrBox.Name = $"GrBox{i}";


                Label lbl = new Label();
                lbl.Name = $"lbl{i}";
                lbl.Text = "";
            }
        }

        void LoadCustomItems ()
        {
            //
            // add account button
            //
            Application.DoEvents();
            RoundedButton AddAccountButton = new RoundedButton();
            AddAccountButton.Text= "Add Account";
            EventHandler myHandler = new EventHandler(AddAccountButton_Click);
            AddAccountButton.Click += myHandler;
            AddAccountButton.Location = new System.Drawing.Point(20, 1765);
            AddAccountButton.Size = new System.Drawing.Size(1040, 135);
            AddAccountButton.BackColor = System.Drawing.Color.FromArgb(53, 170, 68);
            AddAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
            AddAccountButton.ForeColor = System.Drawing.Color.White;
            AddAccountButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            AddAccountButton.FlatAppearance.BorderSize = 0;

            this.Controls.Add(AddAccountButton);
            //
            //
            //
        }

        void AddAccountButton_Click (Object sender, System.EventArgs e)
        {
            MessageBox.Show("success");
        }
    }
}

#region not my code 
//rounded button Credit: https://stackoverflow.com/questions/28486521/rounded-edges-in-button-c-sharp-winforms
class RoundedButton : Button
{
    GraphicsPath GetRoundPath(RectangleF Rect, int radius)
    {
        float r2 = radius / 2f;
        GraphicsPath GraphPath = new GraphicsPath();
        GraphPath.AddArc(Rect.X, Rect.Y, radius, radius, 180, 90);
        GraphPath.AddLine(Rect.X + r2, Rect.Y, Rect.Width - r2, Rect.Y);
        GraphPath.AddArc(Rect.X + Rect.Width - radius, Rect.Y, radius, radius, 270, 90);
        GraphPath.AddLine(Rect.Width, Rect.Y + r2, Rect.Width, Rect.Height - r2);
        GraphPath.AddArc(Rect.X + Rect.Width - radius,
                         Rect.Y + Rect.Height - radius, radius, radius, 0, 90);
        GraphPath.AddLine(Rect.Width - r2, Rect.Height, Rect.X + r2, Rect.Height);
        GraphPath.AddArc(Rect.X, Rect.Y + Rect.Height - radius, radius, radius, 90, 90);
        GraphPath.AddLine(Rect.X, Rect.Height - r2, Rect.X, Rect.Y + r2);
        GraphPath.CloseFigure();
        return GraphPath;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        RectangleF Rect = new RectangleF(0, 0, this.Width, this.Height);
        using (GraphicsPath GraphPath = GetRoundPath(Rect, 50))
        {
            this.Region = new Region(GraphPath);
            using (Pen pen = new Pen(Color.CadetBlue, 1.75f))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, GraphPath);
            }
        }
    }
}
#endregion