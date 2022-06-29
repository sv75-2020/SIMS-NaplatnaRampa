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
            if (naplata.proveraProsecneBrzine())
            {
                policijaLabel.Show();
            }

            Dictionary<TipVozila, float> cenaPoTipu = Aplikacija.aktivniCenovnik.CenaPoTipu();
            float q = cenaPoTipu[tipVozila];
            iznosLabel.Text = naplata.izracunajCenu().ToString();
        }

        private void FizickaNaplata_Load(object sender, EventArgs e)
        {
            tabliceTBox.ReadOnly = true;
            rsd.Checked = true;
            policijaLabel.Hide();
            uredjajiTabela();
            button1.Enabled = false;
        }

        private void uredjajiTabela()
        {
            DataTable uredjajiTable = new DataTable();
            uredjajiTable.Columns.Add("Uređaj");
            uredjajiTable.Columns.Add("Ispravno radi");
            uredjajiTable.Rows.Add("Citac tablice", naplatnoMesto.citacTablica.RadiDaNe());
            uredjajiTable.Rows.Add("Semafor", naplatnoMesto.semafor.RadiDaNe());
            uredjajiTable.Rows.Add("Rampa", naplatnoMesto.rampa.RadiDaNe());
            if (naplatnoMesto.elektronsko)
            {
                uredjajiTable.Rows.Add("Citac taga", naplatnoMesto.citacTaga.RadiDaNe());
            }
            uredjajiGridView.DataSource = uredjajiTable;
        }

        private void ucitajBtn_Click(object sender, EventArgs e)
        {
            tabliceTBox.Text = naplatnoMesto.citacTablica.ocitajTablicu();
            vremeTBox.Text = "";
            policijaLabel.Hide();
            rsd.Checked = true;
            policijaLabel.Hide();
            rampaStanje.Text = "Rampa: spuštena";
            button1.Enabled = true;
            ucitajBtn.Enabled = false;
        }

        private float vratiKusur(float novac)
        {
            rampaStanje.Text = "Rampa: dignuta";
            float iznos = float.Parse(iznosLabel.Text);
            if (novac > iznos)
            {
                return novac - iznos;
            }
            return 0;
        }

        private void uplacenoTBox_TextChanged(object sender, EventArgs e)
        {
            if (uplacenoTBox.Text != "")
            {
                kusurLabel.Text = vratiKusur(float.Parse(uplacenoTBox.Text)).ToString();
            }
        }

        private void kvarBtn_Click(object sender, EventArgs e)
        {
            if (uredjajiGridView.SelectedRows.Count > 0)
            {
                int rowIndex = uredjajiGridView.CurrentCell.RowIndex;
                switch (rowIndex)
                {
                    case 0:
                        naplatnoMesto.citacTablica.setRadi(false);
                        break;
                    case 1:
                        naplatnoMesto.semafor.setRadi(false);
                        break;
                    case 2:
                        naplatnoMesto.rampa.setRadi(false);
                        break;
                    case 3:
                        naplatnoMesto.citacTaga.setRadi(false);
                        break;
                    default:
                        break;
                }
                uredjajiTabela();
            }
        }

        
    }
}
