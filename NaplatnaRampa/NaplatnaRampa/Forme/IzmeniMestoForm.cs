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
    public partial class IzmeniMestoForm : Form
    {
        NaplatnaStanica napStanica;

        public IzmeniMestoForm(NaplatnaStanica stanica)
        {
            InitializeComponent();
            this.napStanica = stanica;
        }

        private void IzmeniMestoForm_Load(object sender, EventArgs e)
        {
            confirm_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            foreach (NaplatnoMesto mesto in napStanica.naplatnaMesta)
            {
                edit_cb.Items.Add(mesto.id);
            }
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            if (edit_cb.SelectedIndex != -1)
            {
                string mestoId = edit_cb.SelectedItem.ToString();
                var touple = napStanica.FindMesto(mestoId);
                NaplatnoMesto mesto = touple.Item1;
                int poz = touple.Item2;

                napStanica.EditMesto(mesto, poz);

                if (mesto.elektronsko)
                {
                    MessageBox.Show("Odabrano naplatno mesto je sada elektronsko.");
                    this.Hide();
                }     
                else
                {
                    MessageBox.Show("Odabrano naplatno mesto vise nije elektronsko.");
                    this.Hide();
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
