using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeptunClone.Data.Timetable
{
    public class GetTimeTableDB
    {
        private static string? day;
        private static string? time;
        private static string? subjectName;
        public static List<TimeTable> timetable = new List<TimeTable>();
        private static Label timeTableLabel = new();
        public static void GetDay(string text)
        {
            day = text;
        }
        public static void GetTime(string text)
        {
            time = text;
        }
        public static void GetSubjectName(string text)
        {
            subjectName = text;
        }
        public static void GetTimeTableLabel(Label label)
        {
            timeTableLabel = label;
        }
        public static void GetTimeTable()
        {
            List<TimeTable> timetable = new List<TimeTable>()
            {
                new TimeTable(){
                    day = day,
                    time = time,
                    SubjectName = subjectName
                }
            };
            for (int i = 0; i < timetable.Count; i++)
            {
                timeTableLabel.Text += "\n"
                    + "Nap: " + timetable[i].day + "\n"
                    + "Időpont: " + timetable[i].time + "\n"
                    + "Tárgy neve: " + timetable[i].SubjectName + "\n";
            }

        }
    }
}
