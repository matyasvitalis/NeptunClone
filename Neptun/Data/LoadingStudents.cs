using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Neptun.Data
{
    internal class LoadingStudents
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
