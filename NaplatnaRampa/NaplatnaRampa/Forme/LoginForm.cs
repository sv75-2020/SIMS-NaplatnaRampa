using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NaplatnaRampa.Forme;

namespace NaplatnaRampa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public string FindUser(string email, string password)
        {
            string userFileName = "../../Data/users.txt";
            string[] lines = File.ReadAllLines(userFileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                if (email == data[1] && password == data[2]) { return data[3]; }
            }
            return null;
        }

        public string FindUserId(string email, string password)
        {
            string userFileName = "../../Data/users.txt";
            string[] lines = File.ReadAllLines(userFileName);
            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                if (email == data[1] && password == data[2]) { return data[0]; }
            }
            return null;
        }

        public void OpenUserForm(string userType)
        {
            switch (userType)
            {
                case "admin":
                    var adminForm = new AdminForm();
                    adminForm.Show();
                    break;
                case "sef":
                    var sefForm = new SefForm();
                    sefForm.Show();
                    break;
                case "radnik":
                    var radnikForm = new FizickaNaplata(2, 2);
                    radnikForm.Show();
                    break;
                case "menadzer":
                    var menadzerForm = new MenadzerForm();
                    menadzerForm.Show();
                    break;
                default:
                    break;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            login_btn.FlatStyle = FlatStyle.Flat;
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Aplikacija.userId = Int32.Parse(FindUserId(username_tb.Text, password_tb.Text));
            string userType = FindUser(username_tb.Text, password_tb.Text);
            if (!(userType is null))
            {
                OpenUserForm(userType);
            }
        }
    }
}
