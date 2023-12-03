using MySql.Data.MySqlClient;
using NeptunClone.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptunClone.Data.Subject
{
    internal class HaveSubjectsLoading
    {
        private static string? userID;
        private static string? specialisation;
        private static string? subjectName;
        public static void getUserID(string text)
        {
            userID = text;
        }

        public static void LoadHaveSubjectsDB()
        {
            DataBaseConnection.GetDataBase("students");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "SELECT * FROM felvetttargyak WHERE neptunID=@neptunID";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", userID);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                specialisation = reader.GetString("szak");
                subjectName = reader.GetString("targyneve");
                GetHaveSubjectsDB.GetSpecialisation(specialisation);
                GetHaveSubjectsDB.GetSubjectName(subjectName);
                GetHaveSubjectsDB.GetHaveSubjects();
            }
            reader.Close();
            connection.Close();
        }
    }
}
