using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptun.Data
{
    public class Student
    {
        public string? id { get; set; }
        public string? firstName { get; set; }
        public string? lastName { get; set; }
        public int age { get; set; }
        public string? email { get; set; }

        public enum Specialisation
        {
            PTI_bsc,
            PTI_foszk,
            szlavisztika_ukran,
            legijarmu_vezetes,
            magyar_info
        }
        public string? selectedSpecialisation { get; set;  }

        public class AddingNewStudent
        {
            public string id { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public int age { get; set; }
            public string email { get; set; }
            public Specialisation Specialisation { get; set; }

            // Student constructor
            public AddingNewStudent(string _id, string _firstName, string _lastName, int _age, string _email, Specialisation specialisation)
            {
                id = _id;
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                email = _email;
                Specialisation = specialisation;

            }
        }
    }
}
