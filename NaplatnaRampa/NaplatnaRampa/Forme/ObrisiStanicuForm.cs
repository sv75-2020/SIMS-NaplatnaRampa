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
    public partial class ObrisiStanicuForm : Form
    {
        public ObrisiStanicuForm()
        {
            InitializeComponent();
        }

        private void confirm_btn_Click(object sender, EventArgs e)
        {
            string id = delete_cb.SelectedItem.ToString();
            NaplatnaStanica stanica = Aplikacija.FindStanica(id);
            Aplikacija.RemoveStanicaFromFile(stanica);
            MessageBox.Show("Stanica obrisana!");
            this.Hide();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ObrisiStanicuForm_Load(object sender, EventArgs e)
        {
            confirm_btn.FlatStyle = FlatStyle.Flat;
            cancel_btn.FlatStyle = FlatStyle.Flat;
            foreach (NaplatnaStanica stanica in Aplikacija.naplatneStanice)
            {
                delete_cb.Items.Add(stanica.id);
            }
        }
    }
}
