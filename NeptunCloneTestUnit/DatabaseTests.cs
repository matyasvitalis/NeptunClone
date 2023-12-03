using MySql.Data.MySqlClient;
using NeptunClone.Data.Course;
using NeptunClone.Data.Subject;
using NeptunClone.Database;

namespace NeptunCloneTestUnit
{
    [TestClass]
    public class DatabaseTests
    {
        [TestMethod]
        public void CourseDataBaseTest()
        {
            // Arrange
            string neptunID = "RIN001";
            string timetableInfo = "";
            string subjectName = "";
            int numbersofTime = 0;
            string teacherInfo = "";
            List<Course> haveCourses = new List<Course>();
            // Act
            DataBaseConnection.GetDataBase("students");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "SELECT * FROM kurzus WHERE neptunID=@neptunID";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", neptunID);
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

            haveCourses = new List<Course>()
            {
                new Course(){
                    SubjectName = subjectName,
                    NumbersOfTime = numbersofTime,
                    TimeTableInfo = timetableInfo,
                    TeacherInfo = teacherInfo
                }
            };
            // Assert
            Assert.IsNotNull(haveCourses);
        }
        [TestMethod]
        public void DataBaseConnectionTest()
        {
            // Arrange
            MySqlConnection connection = new MySqlConnection();
            // Act
            DataBaseConnection.GetDataBase("students");
            connection = DataBaseConnection.Connection;
            // Assert
            Assert.IsNotNull(connection);
        }
        [TestMethod]
        public void SubjectDataBaseTest()
        {
            // Arrange
            string neptunID = "RIN001";
            string specialisation = "";
            string SubjectName = "";
            // Act
            DataBaseConnection.GetDataBase("students");
            MySqlConnection connection = DataBaseConnection.Connection;
            string CommandString = "SELECT * FROM felvetttargyak WHERE neptunID=@neptunID";
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", neptunID);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                specialisation = reader.GetString("szak");
                SubjectName = reader.GetString("targyneve");
            }
            reader.Close();
            connection.Close();
            List<HaveSubjects> haveSubjects = new List<HaveSubjects>()
            {
                new HaveSubjects(){
                    specialisation = specialisation,
                    SubjectName = SubjectName
                }
            };
            // Assert
            Assert.IsNotNull(haveSubjects);
        }
        }
    }

