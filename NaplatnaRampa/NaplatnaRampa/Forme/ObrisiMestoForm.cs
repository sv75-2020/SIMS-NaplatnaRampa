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
    public partial class ObrisiMestoForm : Form
    {
        NaplatnaStanica napStanica;

        public ObrisiMestoForm(NaplatnaStanica stanica)
        {
            InitializeComponent();
            this.napStanica = stanica;
        }

        private void ObrisiMestoForm_Load(object sender, EventArgs e)
        {
            confirm_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.FlatStyle = FlatStyle.Flat;

            foreach (NaplatnoMesto mesto in napStanica.naplatnaMesta)
            {
                delete_cb.Items.Add(mesto.id);
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (delete_cb.SelectedIndex != -1)
            {
                string mestoId = delete_cb.SelectedItem.ToString();
                var touple = napStanica.FindMesto(mestoId);
                NaplatnoMesto mesto = touple.Item1;
                int poz = touple.Item2;

                napStanica.RemoveMestoFromFile(mesto, poz);
                MessageBox.Show("Naplatno mesto obrisano!");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Niste odabrali naplatno mesto za brisanje.");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
