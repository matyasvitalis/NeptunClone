using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using NeptunClone.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptunClone.Data.Timetable
{
    internal class TimeTableLoading
    {
        private static string? userID;
        private static string? day;
        private static string? time;
        private static string? subjectName;

        public static void getUserID(string text)
        {
            userID = text;
        }
        public static void LoadTimeTableDB()
        {
            DataBaseConnection.GetDataBase("students");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "SELECT * FROM diakorarend WHERE neptunID=@neptunID";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", userID);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                day = reader.GetString("nap");
                time = reader.GetString("idopont");
                subjectName = reader.GetString("TargyNeve");
                GetTimeTableDB.GetDay(day);
                GetTimeTableDB.GetTime(time);
                GetTimeTableDB.GetSubjectName(subjectName);
                GetTimeTableDB.GetTimeTable();
            }
            reader.Close();
            connection.Close();
        }
    }
}
