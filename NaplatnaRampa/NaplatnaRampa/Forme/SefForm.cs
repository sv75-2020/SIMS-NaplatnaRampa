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
    public partial class SefForm : Form
    {
        public NaplatnaStanica stanica = new NaplatnaStanica(2,"NS");
        
        public SefForm()
        {
            InitializeComponent();
            stanica = Aplikacija.FindStanica(stanica.Id().ToString());
        }

        private void zarada_stanica_btn_Click(object sender, EventArgs e)
        {
            izvestaj.Text = "";
            izvestaj.Text = "Prihodi stanice " + stanica.Id() + ": " + stanica.stampajIzvestaj(dateTimePicker1.Value,dateTimePicker2.Value);
        }

        private void SefForm_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IspravnostForm forma = new IspravnostForm(stanica);
            forma.Show();
        }
    }
}
