using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hangman
{
    public partial class Login : Form
    {
        public string UserInAction { get; set; }
        List<string> usernames = new List<string>();
        List<string> passwords = new List<string>();
        string fileName = "users.txt";

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string inputUsername = tbUsername.Text.Trim();
            string inputPass = tbPassword.Text.Trim();
            bool isFound = false;

            for (int i = 0; i < usernames.Count; i++)
            {
                if (usernames[i] == inputUsername && passwords[i] == inputPass)
                {
                    isFound = true;
                    this.UserInAction = tbUsername.Text;
                    MessageBox.Show("Успешно влизане");
                    tbUsername.Clear();
                    tbPassword.Clear();
                    //this.Close();
                    AddNewWord goToWords = new AddNewWord();
                    goToWords.ShowDialog();
                }
            }

            if (!isFound)
            {
                MessageBox.Show("Опитай отново");
                tbUsername.Clear();
                tbPassword.Clear();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string pass = tbPassword.Text.Trim();

            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(pass))
            {   
                tbUsername.Clear();
                tbPassword.Clear();
                MessageBox.Show("Опитай отново");
            }
            else
            {
                if (usernames.Contains(username))
                {
                    MessageBox.Show("Потребителят съществува");
                    tbUsername.Clear();
                    tbPassword.Clear();
                    return;
                }

                using (StreamWriter sw = new StreamWriter(fileName, true))
                {
                    sw.WriteLine(username);
                    sw.WriteLine(pass);
                    usernames.Add(username);
                    passwords.Add(pass);
                }
                MessageBox.Show("Успешна регистрация");
                tbUsername.Clear();
                tbPassword.Clear();
            }
       }

        private void Login_Load(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fs))
                {
                    while (!sr.EndOfStream)
                    {
                        string dbUsername, dbPass;

                        dbUsername = sr.ReadLine();
                        dbPass = sr.ReadLine();
                        usernames.Add(dbUsername);
                        passwords.Add(dbPass); 
                    }
                }
            }
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
                btnLogin_Click(sender, e);
            }
        }
   }
}

