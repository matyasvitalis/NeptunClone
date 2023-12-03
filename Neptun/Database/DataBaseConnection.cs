using MySql.Data.MySqlClient;
using Neptun.Login;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg;

namespace NeptunClone.Database
{   
    public class DataBaseConnection
    {
        private static MySqlConnection? _connection;
        public static string? database; //userdata, students

        public static void GetDataBase(string text)
        {
            database = text;
        }
        public static MySqlConnection Connection {
            get
            {
                _connection = null;
                if (_connection == null)
                {
                        string cs = @"server=127.0.0.1; user id=root; password=''; database=" + database + "";
                        _connection = new MySqlConnection(cs);
                }
                if (_connection.State == ConnectionState.Closed)
                    try
                    {
                        _connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                return _connection;
            }
        }
    }
}
