using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neptun.Data
{
    public class Student
    {
        public string? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }

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
            public string Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string Email { get; set; }
            public Specialisation Specialisation { get; set; }

            // Student constructor
            public AddingNewStudent(string _id, string _firstName, string _lastName, int _age, string _email, Specialisation specialisation)
            {
                Id = _id;
                FirstName = _firstName;
                LastName = _lastName;
                Age = _age;
                Email = _email;
                Specialisation = specialisation;

            }
        }
    }
}
