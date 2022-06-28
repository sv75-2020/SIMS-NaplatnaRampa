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
        int idNapMesta;
        int idNapStanice;
        NaplatnoMesto naplatnoMesto;
        public FizickaNaplata(int idNapMesta, int idNapStanice)
        {
            InitializeComponent();
            NaplatnaStanica stanica = Aplikacija.FindStanica(idNapStanice.ToString());
            (naplatnoMesto, _) = stanica.FindMesto(idNapMesta.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string tablica = tabliceTBox.Text;
            DateTime vremeIzlaska = DateTime.Now;
            string ulazak = vremeTBox.Text;
            DateTime vremeUlaska = DateTime.Parse(ulazak);
            string mestoUlaska = mestoUlaskaCBox.SelectedItem.ToString();
            string deonica = mestoUlaska;
            deonica += "-";
            deonica += naplatnoMesto.stanica.lokacija;
            string tip = tipVozilaCBox.SelectedItem.ToString();
            Enum.TryParse<TipVozila>(tip, out TipVozila tipVozila);
            bool evri = false;
            if (eur.Checked)
            {
                evri = true;
            }
            string userId = Aplikacija.userId.ToString();
            string newId = naplatnoMesto.newId();
            

            Naplata naplata = new Naplata(Int32.Parse(newId), tipVozila, deonica, evri, vremeIzlaska, vremeUlaska, tablica, 0, idNapStanice, Int32.Parse(userId));
            iznosLabel.Text = naplata.izracunajCenu().ToString();

        }

        private void FizickaNaplata_Load(object sender, EventArgs e)
        {
            tabliceTBox.ReadOnly = true;
            rsd.Checked = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabliceTBox.Text = naplatnoMesto.citacTablica.ocitajTablicu();

        }

        private float vratiKusur(float novac)
        {
            float iznos = float.Parse(iznosLabel.Text);
            if (novac > iznos)
            {
                return novac - iznos;
            }
            return 0;
        }

        private void uplacenoTBox_TextChanged(object sender, EventArgs e)
        {
            kusurLabel.Text = vratiKusur(float.Parse(uplacenoTBox.Text)).ToString();
        }
    }
}
