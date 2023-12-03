using MySql.Data.MySqlClient;
using NeptunClone.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace NeptunClone.Data.Student
{
    public class LoadingStudentsDB
    {
        public static List<Student> student = new();
        public static Label resultLabel = new();

        public static void GetList(List<Student> list)
        {
            student = list;
        }

        public static void GetTextBox(Label label)
        {
            resultLabel = label;
        }
        public static void LoadStudents()
        {
            for (int i = 0; i < student.Count; i++)
            {
                DataBaseConnection.GetDataBase("userdata");
                MySqlConnection connection = DataBaseConnection.Connection;
                string CommandString;
                CommandString = "INSERT INTO students(neptunID, firstName, lastName, age, emailAddress, specialisation) " +
                    "VALUES(@neptunID, @firstName, @lastName, @age, @emailAddress, @specialisation)";
                MySqlCommand command = new MySqlCommand(CommandString, connection);
                command.Parameters.AddWithValue("@neptunID", student[i].Id);
                command.Parameters.AddWithValue("@firstName", student[i].FirstName);
                command.Parameters.AddWithValue("@lastName", student[i].LastName);
                command.Parameters.AddWithValue("@age", student[i].Age);
                command.Parameters.AddWithValue("@emailAddress", student[i].Email);
                command.Parameters.AddWithValue("@specialisation", student[i].selectedSpecialisation);
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

                resultLabel.Text += "Student" + " data: " + "\n" + "ID: " + student[i].Id + "\n"
               + "First name: " + student[i].FirstName + "\n"
               + "Last name: " + student[i].LastName + "\n"
               + "Age: " + student[i].Age + "\n"
               + "Email address: " + student[i].Email + "\n"
               + "Specialisation: " + student[i].selectedSpecialisation + "\n";
                /*  MessageBox.Show("Student" + " data: " + "\n" + "ID: " + student[i].id + "\n"
                 + "First name: " + student[i].firstName + "\n"
                 + "Last name: " + student[i].lastName + "\n"
                 + "Age: " + student[i].age + "\n"
                 + "Email address: " + student[i].email + "\n"
                 + "Specialisation: " + student[i].selectedSpecialisation + "\n"); */
            }
        }
    }
}
