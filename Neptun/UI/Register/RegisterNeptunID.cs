using MySql.Data.MySqlClient;
using Neptun.Login;
using NeptunClone.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace NeptunClone.UI.Register
{   
    public class RegisterNeptunID
    {
        static string textboxPassword = "";
        static string? textboxUsername;

        public static void TextBoxPassword(string text)
        {
            textboxPassword = text;
        }

        public static void TextBoxUsername(string text)
        {
            textboxUsername = text;
        }

        public static void NeptunIDRegistration() 
        {
            // REGISZTRÁCIÓhoz használható kód
              var hash = HashPasswordMethod.HashPassword(textboxPassword, out var salt);
               DataBaseConnection.GetDataBase("userdata");
               MySqlConnection connection = DataBaseConnection.Connection;
              string CommandString;
              CommandString = "INSERT INTO users(neptunID, NeptunUserHash, NeptunUserSalt) VALUES(@neptunID, @NeptunUserHash, @NeptunUserSalt)";
              MySqlCommand command = new MySqlCommand(CommandString, connection);
              command.Parameters.AddWithValue("@neptunID", textboxUsername);
              command.Parameters.AddWithValue("@NeptunUserHash", hash);
              command.Parameters.AddWithValue("@NeptunUserSalt", salt);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres regisztráció!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
            
        }


    }
}
