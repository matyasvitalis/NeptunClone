using EnvDTE;
using MySql.Data.MySqlClient;
using Neptun.Login;
using NeptunClone.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeptunClone.UI.MainUI
{
    public partial class MainPage : Form
    {
        LoginForm loginpage = new LoginForm();
        static string? neptunID;
        static string? lastName;
        public static void NeptunID(string text)
        {
            neptunID = text;
        }
        public static void DBConnect()
        {
            DataBaseConnection.GetDataBase("students");
            string CommandString = "SELECT * FROM students WHERE neptunID=@neptunID";
            MySqlConnection connection = DataBaseConnection.Connection;
            MySqlCommand command = new MySqlCommand(CommandString, connection);
            command.Parameters.AddWithValue("@neptunID", neptunID);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lastName = reader.GetString("lastName");
                //MessageBox.Show("Sikeres reader!");
            }
            reader.Close();
            connection.Close();
        }
        public MainPage()
        {
            InitializeComponent();
        }
        private void MainPage_Load(object sender, EventArgs e)
        {
            DBConnect();
            toolStripStatusLabel1.Text = "Üdvözöljük " + lastName + "!";
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            toolStripStatusLabel1.Text = null;
            lastName = null;
            MessageBox.Show("Sikeres kijelentkezés!", "Állapot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginpage.ShowDialog();
            this.Close();
        }


    }
}
