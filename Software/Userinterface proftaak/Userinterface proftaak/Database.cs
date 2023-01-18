using System.Collections.Generic;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using uPLibrary.Networking.M2Mqtt;
using System.Collections;

namespace Userinterface_proftaak
{
    internal class Database
    {
        private string Connectionstring;
        private SqlConnection Connection;
        public bool Valid { get; private set; }
        public string Username { get; private set; }

        public void ConnectionDatabase() //security issue
        {
            Connectionstring = @"Data Source=145.220.75.105;Initial Catalog=Recycle Project;User Id=SA;Password=04juLi2003!; MultipleActiveResultSets=true";
            Connection = new SqlConnection(Connectionstring);
            Connection.Open();
            //close connection every time a query is made. It is not good to use the same connection for multiple query
        }

        public void WriteDatabase(string uuid, double weightvalue, int materialid) //primitive
        {
            ConnectionDatabase();//establish connection

            //insert into database
            string query = $"INSERT INTO Weights(UUID, Location, Weight, Reading_time, Material_id) VALUES('{uuid}', 'Eindhoven', '{weightvalue}', CAST(GETDATE() AS Date), '{materialid}')";
            SqlCommand cmd = new SqlCommand(query, Connection);
            cmd.ExecuteNonQuery();
            Connection.Close();
        }

        public bool ValidateCard(string userid, bool valid)
        {
            ConnectionDatabase();//establish connection
            //read from database
            string query = "SELECT UUID FROM Users";//define the query 
            SqlCommand cmd = new SqlCommand(query, Connection);
            SqlDataReader reader = cmd.ExecuteReader();//define reader
            reader.Read();
            if (userid == reader["UUID"].ToString())
            {
                valid = true;
                query = $"SELECT Username FROM Users WHERE UUID = '{userid}'";
                SqlCommand cmd2 = new SqlCommand(query, Connection);
                SqlDataReader reader2 = cmd2.ExecuteReader();
                reader2.Read();
                Username = reader2["Username"].ToString();
                reader.Close();
                reader2.Close();
                Connection.Close();
                Valid = valid;
                return Valid;
            }
            else if(userid != "0")
            {
                MessageBox.Show("Invalid Card");
                return Valid;
            }
            return Valid;
        }
    }
}
