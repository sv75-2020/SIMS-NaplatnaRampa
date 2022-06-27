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
        public AdminForm()
        {
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            napraviStanicu_btn.FlatStyle = FlatStyle.Flat;
            obrisiStanicu_btn.FlatStyle = FlatStyle.Flat;
            logOut_btn.FlatStyle = FlatStyle.Flat;
            manageMesta_btn.FlatStyle = FlatStyle.Flat;
            zarada_stanica_btn.FlatStyle = FlatStyle.Flat;
            cenovnik.FlatStyle = FlatStyle.Flat;
        }

        private void napraviStanicu_btn_Click(object sender, EventArgs e)
        {
            var napraviStanicuForm = new NapraviStanicuForm();
            napraviStanicuForm.Show();
        }

        private void logOut_btn_Click(object sender, EventArgs e)
        {
            var loginForm = new LoginForm();
        }

        private void zarada_stanica_btn_Click(object sender, EventArgs e)
        {
            izvestaj.Text = "";
            float ukupno = 0;
            foreach(NaplatnaStanica stanica in Aplikacija.naplatneStanice)
            {
                float zarada = stanica.stampajIzvestaj(dateTimePicker1.Value, dateTimePicker2.Value);
                izvestaj.Text += "Prihodi stanice " + stanica.Id() + ": " + zarada +"\n";
                ukupno += zarada;
            }
            izvestaj.Text += "UKUPNO: " + ukupno;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void izvestaj_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cenovnik_Click(object sender, EventArgs e)
        {
            string cenovnik = "";
            cenovnik += "Cenovnik vazi od: " + Aplikacija.aktivniCenovnik.Pocetak() + " do: " + Aplikacija.aktivniCenovnik.Kraj()+"\n";
            cenovnik += "Cena iznosi: " + Aplikacija.aktivniCenovnik.CenaPoKm() + "\n";
            foreach(var pair in Aplikacija.aktivniCenovnik.CenaPoTipu())
            {
                cenovnik += "Cena za " + pair.Key.ToString() + " iznosi: " + pair.Value* Aplikacija.aktivniCenovnik.CenaPoKm()+"\n";
            }
            MessageBox.Show(cenovnik);
        }

        private void obrisiStanicu_btn_Click(object sender, EventArgs e)
        {
            var obrisiStanicuForm = new ObrisiStanicuForm();
            obrisiStanicuForm.Show();
        }

        private void manageMesta_btn_Click(object sender, EventArgs e)
        {
            var manageMestaForm = new ManageMestaForm();
            manageMestaForm.Show();
        }
    }
}
