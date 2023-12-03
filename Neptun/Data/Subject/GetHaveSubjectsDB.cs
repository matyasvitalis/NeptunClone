using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace NeptunClone.Data.Subject
{
    public class GetHaveSubjectsDB
    {
        private static string? specialisation;
        private static string? subjectName;
        private static Label haveSubjectsLabel = new();
        static List<HaveSubjects> haveSubjects = new List<HaveSubjects>();

        public static void GetSpecialisation(string text)
        {
            specialisation = text;
        }
        public static void GetSubjectName(string text)
        {
            subjectName = text;
        }
        public static void GetHaveSubjectsLabel(Label label)
        {
            haveSubjectsLabel = label;
        }
        public static void GetHaveSubjects()
        {
            List<HaveSubjects> haveSubjects = new List<HaveSubjects>()
            {
                new HaveSubjects(){
                    specialisation = specialisation,
                    SubjectName = subjectName
                }
            };
            for (int i = 0; i < haveSubjects.Count; i++)
            {
                haveSubjectsLabel.Text += "\n"
                    + "Szak: " + haveSubjects[i].specialisation + "\n"
                    + "Tárgy neve: " + haveSubjects[i].SubjectName + "\n";
            }
        }
    }
}

