using MySql.Data.MySqlClient;
using Neptun.Login;
using NeptunClone.Database;
using NeptunClone.UI.MainUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptunClone.UI.Login
{
    internal class LoginUserDB
    {
        private static string userID = "";
        private static string userPassword = "";

        public static void GetUserID(string text) 
        {
            userID = text;
        }
        public static void GetPassword(string text)
        {
            userPassword = text;
        }
        public static void UserLogin()
        {
            DataBaseConnection.GetDataBase("userdata");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "SELECT * FROM users WHERE neptunID=@neptunID";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", userID);
            string PasswordHash = "";
            string LoginName = "";
            byte[] PasswordSalt = new byte[1024];
            string checkLoginName = userID; // ez így ok!
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                PasswordHash = reader.GetString("NeptunUserHash");
                PasswordSalt = (byte[])reader["NeptunUserSalt"];
                LoginName = reader.GetString("neptunID");
            }
            reader.Close();
            connection.Close();

            if (checkLoginName == LoginName || checkLoginName == LoginName.ToLower())
            {
                if (VerifyPasswordMethod.VerifyPassword(userPassword, PasswordHash, PasswordSalt))
                {
                    MessageBox.Show("Sikeres bejelentkezés", "Állapot", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoginForm.GetLoginStatus(true);
                    MainPage.NeptunID(LoginName);
                }
                else
                {
                    MessageBox.Show("Sikertelen bejelentkezés! Hibás azonosító vagy jelszó!", "Állapot", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LoginForm.GetLoginStatus(false);
                }
            }
            else
            {
                MessageBox.Show("Helytelen azonosító vagy jelszó!");
                LoginForm.GetLoginStatus(false);
            }
        }
    }
}
