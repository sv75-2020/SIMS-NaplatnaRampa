using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NaplatnaRampa.Forme
{
    public partial class AdminForm : Form
    {
        Aplikacija aplikacija = new Aplikacija();

        public AdminForm()
        {
            InitializeComponent();
        }

        private void napraviStanicu_btn_Click(object sender, EventArgs e)
        {
            var napraviStanicuForm = new NapraviStanicuForm();
            napraviStanicuForm.Show();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            //var loginForm = new LoginForm();
            //this.Hide();
            //loginForm.Show();
        }
    }
}
