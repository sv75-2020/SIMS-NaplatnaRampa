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
    public partial class NapraviMestoForm : Form
    {
        NaplatnaStanica napStanica;

        public NapraviMestoForm(NaplatnaStanica stanica)
        {
            InitializeComponent();
            this.napStanica = stanica;
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            bool elektronsko = false;
            if (electronic_cb.SelectedItem.ToString() == "Elektronsko")
            {
                elektronsko = true;
            }
            bool radi = true;
            if (electronic_cb.SelectedItem.ToString() == "Elektronsko")
            {
                radi = true;
            }
            int idMesta = napStanica.GetNewId();
            NaplatnoMesto mesto = new NaplatnoMesto(idMesta, elektronsko, napStanica, radi, true, true, true, elektronsko);
            napStanica.AddMesto(mesto);
            MessageBox.Show("Dodato novo naplatno mesto!");
            this.Hide();

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void NapraviMestoForm_Load(object sender, EventArgs e)
        {
            confirm_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.FlatStyle = FlatStyle.Flat;

            electronic_cb.Items.Add("Elektronsko");
            electronic_cb.Items.Add("Sa radnikom");
        }
    }
}
