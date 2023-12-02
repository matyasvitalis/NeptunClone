using EnvDTE100;
using Microsoft.VisualStudio.Shell.Interop;
using MySql.Data.MySqlClient;
using NeptunClone.Database;
using NeptunClone.UI.Login;
using NeptunClone.UI.MainUI;
using NeptunClone.UI.Register;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neptun.Login
{
    public partial class LoginForm : Form
    {
        private static bool LoginStatus;
        public LoginForm()
        {
            InitializeComponent();
        }

        public static void GetLoginStatus(bool status)
        {
            LoginStatus = status;
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            RegisterStudentForm f1 = new RegisterStudentForm();
            MainPage mainPageForm = new MainPage();
            if (LoginText.Text == "Regisztráció")
            {
                if (userID_InputBox.Text == "" || userPassword_InputBox.Text == "" || userPasswordConfirm_TextBox.Text == "")
                {
                    MessageBox.Show("Hiányzó adat/adatok!");
                }
                else
                {
                    if (userPassword_InputBox.Text.Equals(userPasswordConfirm_TextBox.Text))
                    {
                        RegisterNeptunID.TextBoxPassword(userPassword_InputBox.Text);
                        RegisterNeptunID.TextBoxUsername(userID_InputBox.Text);
                        RegisterNeptunID.NeptunIDRegistration();
                    }
                    else
                    {
                        MessageBox.Show("A jelszó nem egyezik!");
                    }
                }
            }
            else
            {
                if (userID_InputBox.Text == "" || userPassword_InputBox.Text == "")
                {
                    MessageBox.Show("Hiányzó azonosító vagy jelszó!");
                }
                else
                {
                    // LOGIN
                    LoginUserDB.GetUserID(userID_InputBox.Text);
                    LoginUserDB.GetPassword(userPassword_InputBox.Text);
                    LoginUserDB.UserLogin();
                    if (LoginStatus == true)
                    {
                        this.Hide();
                        mainPageForm.ShowDialog();
                        this.Close();
                    }
                }
                // Manual check
                /* string tempPasswordHash = File.ReadAllText(@"C:\Users\rinachi\Desktop\hash.txt"); //TODO: DB-ből szedni a hasht
                 byte[] tempSalt = File.ReadAllBytes(@"C:\Users\rinachi\Desktop\salt.txt"); //TODO: DB-ből szedni a salt-ot */
                //  string LoginName = "MAN444"; //TODO: DB-ből szedni a azonositot 

                /* var hash = HashPassword(userPassword_InputBox.Text, out var salt);
                 MessageBox.Show("Eredeti jelszó: " + userPassword_InputBox.Text 
                     + "\n" +
                     "Hashelt jelszó: " + hash + "\n" + "Salt jelszó:" + Convert.ToHexString(salt)
                              );
                 File.WriteAllText(@"C:\Users\rinachi\Desktop\hash.txt", hash);
                 File.WriteAllBytes(@"C:\Users\rinachi\Desktop\salt.txt", salt); */
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabel1.Text == "Regisztrálj!")
            {
                LoginForm.ActiveForm.Text = "Regisztráció";
                LoginText.Text = "Regisztráció";
                LoginButton.Text = "Regisztráció";
                PasswordConfirmLabel.Visible = true;
                userPasswordConfirm_TextBox.Visible = true;
                RegisterorLoginText.Text = "Már van Neptunod?";
                linkLabel1.Text = "Jelentkezz be!";
            }
            else
            {
                LoginForm.ActiveForm.Text = "Bejelentkezés";
                LoginText.Text = "Bejelentkezés";
                LoginButton.Text = "Bejelentkezés";
                PasswordConfirmLabel.Visible = false;
                userPasswordConfirm_TextBox.Visible = false;
                RegisterorLoginText.Text = "Még nincs Neptunod?";
                linkLabel1.Text = "Regisztrálj!";
            }
        }
    }
}
