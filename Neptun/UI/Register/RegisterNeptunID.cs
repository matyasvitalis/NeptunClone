using MySql.Data.MySqlClient;
using Neptun.Login;
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
        static int keySize = 64;
        static int iterations = 350000;
        static HashAlgorithmName hashAlgorithm = HashAlgorithmName.SHA512;
        static string? textboxPassword;
        static string? textboxUsername;

        public static void TextBoxPassword(string text)
        {
            textboxPassword = text;
        }

        public static void TextBoxUsername(string text)
        {
            textboxUsername = text;
        }
        
        public static string HashPassword(string password, out byte[] salt)
        {
            salt = RandomNumberGenerator.GetBytes(keySize);
            var hash = Rfc2898DeriveBytes.Pbkdf2(Encoding.UTF8.GetBytes(password), salt, iterations, hashAlgorithm, keySize);

            return Convert.ToHexString(hash);
        }

        public static void NeptunIDRegistration() 
        {   
            // REGISZTRÁCIÓhoz használható kód
              var hash = HashPassword(textboxPassword, out var salt);
              string mySqlConnectionString = "server=127.0.0.1; user=root; database=userdata; password=";
              MySqlConnection mySqlConnection = new MySqlConnection(mySqlConnectionString);
              try
              {
                  mySqlConnection.Open();
                  MessageBox.Show("Sikeres DB csatlakozás!");
              }
              catch (Exception ex)
              {
                  MessageBox.Show(ex.Message);
              }
              string CommandString;
              CommandString = "INSERT INTO users(neptunID, NeptunUserHash, NeptunUserSalt) VALUES(@neptunID, @NeptunUserHash, @NeptunUserSalt)";
              MySqlCommand command = new MySqlCommand(CommandString, mySqlConnection);
              command.Parameters.AddWithValue("@neptunID", textboxUsername);
              command.Parameters.AddWithValue("@NeptunUserHash", hash);
              command.Parameters.AddWithValue("@NeptunUserSalt", salt);
              command.ExecuteNonQuery();
              mySqlConnection.Close(); 
        }


    }
}
