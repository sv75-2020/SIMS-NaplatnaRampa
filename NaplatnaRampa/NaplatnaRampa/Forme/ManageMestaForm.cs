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
    public partial class ManageMestaForm : Form
    {
        public ManageMestaForm()
        {
            InitializeComponent();
        }

        private void napraviMesto_btn_Click(object sender, EventArgs e)
        {
            if (stanica_cb.SelectedIndex != -1)
            {
                NaplatnaStanica stanica = Aplikacija.FindStanica(stanica_cb.SelectedItem.ToString());
                var napraviMestoForm = new NapraviMestoForm(stanica);
                napraviMestoForm.Show();
            }
            else
            {
                MessageBox.Show("Niste odabrali stanicu.");
            }
        }

        private void izmeniMesto_btn_Click(object sender, EventArgs e)
        {
            if (stanica_cb.SelectedIndex != -1)
            {
                NaplatnaStanica stanica = Aplikacija.FindStanica(stanica_cb.SelectedItem.ToString());
                var izmeniMestoForm = new IzmeniMestoForm(stanica);
                izmeniMestoForm.Show();
            }
            else
            {
                MessageBox.Show("Niste odabrali stanicu.");
            }
        }

        private void obrisiMesto_btn_Click(object sender, EventArgs e)
        {
            if (stanica_cb.SelectedIndex != -1)
            {
                NaplatnaStanica stanica = Aplikacija.FindStanica(stanica_cb.SelectedItem.ToString());
                var obrisiMestoForm = new ObrisiMestoForm(stanica);
                obrisiMestoForm.Show();
            }
            else
            {
                MessageBox.Show("Niste odabrali stanicu.");
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ManageMestaForm_Load(object sender, EventArgs e)
        {
            cancel_btn.FlatStyle = FlatStyle.Flat;
            napraviMesto_btn.FlatStyle = FlatStyle.Flat;
            izmeniMesto_btn.FlatStyle = FlatStyle.Flat;
            obrisiMesto_btn.FlatStyle = FlatStyle.Flat;

            foreach (NaplatnaStanica stanica in Aplikacija.naplatneStanice)
            {
                if (stanica.naplatnaMesta.Count() != 0)
                {
                    stanica_cb.Items.Add(stanica.id);
                }
            }
        }
    }
}
