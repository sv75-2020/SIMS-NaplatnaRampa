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
    public partial class NapraviStanicuForm : Form
    {
        public NapraviStanicuForm()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string lokacija = lokacija_tb.Text;
            int id = Aplikacija.GetNewId();
            NaplatnaStanica stanica = new NaplatnaStanica(id, lokacija);
            Aplikacija.AddStanica(stanica);
            MessageBox.Show("Stanica dodata!");
            this.Hide();
        }

        private void NapraviStanicuForm_Load(object sender, EventArgs e)
        {
            confirm_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.FlatStyle = FlatStyle.Flat;
        }

        private void cancel_btn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
