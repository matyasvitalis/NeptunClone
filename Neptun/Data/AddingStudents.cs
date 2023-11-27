using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Neptun.Data
{
    public class AddingStudents
    {
        public static string? textboxID;
        public static string? firstName;
        public static string? lastName;
        public static int? age;
        public static string? email;
        public static string? selectedSpecialisation;
        public static List<Student> student = new List<Student>();

        public static void TextBoxID(string ID)
        {
            textboxID = ID;
        }
        public static void FirstName(string text)
        {
            firstName = text;
        }
        public static void LastName(string text) 
        {
            lastName = text;
        }
        public static void Age(int number)
        {
            age = number;
        }
        public static void Email(string text)
        {
           email = text;
        }
        public static void SelectedSpecialisation(string text)
        {
           selectedSpecialisation = text;
        }

        public static void AddStudent()
        {
           List<Student> student = new List<Student>()
            {
                new Student() {Id = textboxID,
                FirstName = firstName,
                LastName = lastName,
                Age = Convert.ToInt32(age),
                Email = email,
                selectedSpecialisation = selectedSpecialisation}
                };
            LoadingStudents.GetList(student);
        }
    }
}
