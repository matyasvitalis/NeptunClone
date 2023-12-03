using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptunClone.Data.Course
{
    public class GetHaveCoursesDB
    {
        private static string? timetableInfo;
        private static string? subjectName;
        private static int? numbersofTime;
        private static string? teacherInfo;
        private static Label haveCoursesLabel = new();
        static List<Course> haveCourses = new List<Course>();

        public static void GetTimeTableInfo(string text)
        {
            timetableInfo = text;
        }
        public static void GetSubjectName(string text)
        {
            subjectName = text;
        }
        public static void GetHaveCoursesLabel(Label label)
        {
            haveCoursesLabel = label;
        }
        public static void GetNumbersofTime(int number)
        {
            numbersofTime = number;
        }
        public static void GetTeacherInfo(string text)
        {
            teacherInfo = text;
        }
        public static void GetHaveCourses()
        {
            List<Course> haveCourses = new List<Course>()
            {
                new Course(){
                    SubjectName = subjectName,
                    NumbersOfTime = numbersofTime,
                    TimeTableInfo = timetableInfo,
                    TeacherInfo = teacherInfo
                }
            };
            for (int i = 0; i < haveCourses.Count; i++)
            {
                haveCoursesLabel.Text += "\n"
                    + "Tárgy neve: " + haveCourses[i].SubjectName + "\n"
                    + "Óraszám: " + haveCourses[i].NumbersOfTime + "\n"
                    + "Órarend infó: " + haveCourses[i].TimeTableInfo + "\n"
                    + "Oktató: " + haveCourses[i].TeacherInfo + "\n";
            }
        }
    }
}
