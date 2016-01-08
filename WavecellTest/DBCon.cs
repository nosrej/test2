using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace WavecellTest
{
    public class DBCon
    {
        private SqlConnection connection;

        public void DBConnect()
        {
            //string constring = "server = localhost; database = Exam; Integrated Security = True;";
            //connection = new SqlConnection(constring);
        }


        public SqlConnection GetConnection()
        {
            string constring = @"Data Source=.\SQLEXPRESS;" +
                @"AttachDbFilename=|DataDirectory|\ASPNETDB.mdf;
                Integrated Security=True;
                Connect Timeout=30;
                User Instance=True";
            connection = new SqlConnection(constring);
            return connection;
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}