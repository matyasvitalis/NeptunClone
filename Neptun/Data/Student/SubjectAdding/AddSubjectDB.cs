using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using NeptunClone.Data.Timetable;
using NeptunClone.Database;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace NeptunClone.Data.Student.SubjectAdding
{
    public class AddSubjectDB
    {
        private static string? szak;
        public string? targy {get;set;}
        private static string? neptunID;
        private static string? selectedSubject;
        public static List<AddSubjectDB> subjects = new List<AddSubjectDB>();
        public static ListBox ListBox = new ListBox();
        public static void GetNeptunID(string text)
        {
            neptunID = text;
        }
        public static void GetListBox(ListBox listbox)
        {
            ListBox = listbox;
        }
        public static void GetSelectedSubject(string text)
        {
            selectedSubject = text;
        }
        public static void LoadSubjectsfromDB()
        {
            DataBaseConnection.GetDataBase("tantargyak");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "SELECT TargyNeve FROM tantargylista WHERE szak=@szak";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@szak", szak);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string temp;
                temp = reader.GetString("TargyNeve");
                List<AddSubjectDB> subjects = new List<AddSubjectDB>()
            {
                new AddSubjectDB(){
                    targy = temp
                }
            };
                for (int i = 0; i < subjects.Count; i++)
                {
                    ListBox.Items.Add(subjects[i].targy);
                }
            }
            reader.Close();
            connection.Close();
        }
        public static void FindSzakfromDB()
        {
            DataBaseConnection.GetDataBase("students");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "SELECT specialisation FROM students WHERE neptunID=@neptunID";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", neptunID);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                szak = reader.GetString("specialisation");
            }
            reader.Close();
            connection.Close();
        }
        public static void AddSzaktoStudentTable() 
        {
            DataBaseConnection.GetDataBase("students");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "INSERT into felvetttargyak (neptunID, szak, targyneve) " + "VALUES(@neptunID, @szak, @targyneve)";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", neptunID);
            command.Parameters.AddWithValue("@szak", szak);
            command.Parameters.AddWithValue("@targyneve", selectedSubject);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Sikeres felvitel az adatbázisba!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            connection.Close();
        }
    }
    }

