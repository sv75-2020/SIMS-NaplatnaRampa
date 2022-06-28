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
    public partial class FizickaNaplata : Form
    {
        public FizickaNaplata()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tablica = tabliceTBox.Text;
            DateTime vremeIzlaska = DateTime.Now;
            string ulazak = vremeTBox.Text;
            DateTime vremeUlaska = DateTime.Parse(ulazak);
            string tipVozila = tipVozilaCBox.SelectedItem.ToString();
            bool evri = false;
            if (eur.Checked)
            {
                evri = true;
            }

            //Naplata naplata = new Naplata();


        }

        private void FizickaNaplata_Load(object sender, EventArgs e)
        {
            tabliceTBox.ReadOnly = true;
            rsd.Checked = true;
        }
    }
}
