using MySql.Data.MySqlClient;
using NeptunClone.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptunClone.Data.Course
{
    public class CourseLoading
    {
        private static string? userID;
        private static string? timetableInfo;
        private static string? subjectName;
        private static int numbersofTime;
        private static string? teacherInfo;
        public static void getUserID(string text)
        {
            userID = text;
        }
        public static void LoadHaveCoursesDB()
        {
            DataBaseConnection.GetDataBase("students");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "SELECT * FROM kurzus WHERE neptunID=@neptunID";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", userID);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                timetableInfo = reader.GetString("OrarendInfo");
                subjectName = reader.GetString("TargyNeve");
                numbersofTime = reader.GetInt32("oraszam");
                teacherInfo = reader.GetString("Oktato");
                GetHaveCoursesDB.GetTimeTableInfo(timetableInfo);
                GetHaveCoursesDB.GetSubjectName(subjectName);
                GetHaveCoursesDB.GetNumbersofTime(numbersofTime);
                GetHaveCoursesDB.GetTeacherInfo(teacherInfo);
                GetHaveCoursesDB.GetHaveCourses();
            }
            reader.Close();
            connection.Close();
        }
    }
}
