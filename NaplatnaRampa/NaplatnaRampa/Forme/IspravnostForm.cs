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
    public partial class IspravnostForm : Form
    {
        DataTable mesta = new DataTable();
        NaplatnaStanica stanica;
        public IspravnostForm(NaplatnaStanica stanica)
        {
            InitializeComponent();
            this.stanica = stanica;
            CreateTable();
        }

        private void IspravnostForm_Load(object sender, EventArgs e)
        {
            foreach (NaplatnoMesto mesto in stanica.naplatnaMesta)
            {
                string radi = "NE";
                if (mesto.Radi())
                    radi = "DA";
                mesta.Rows.Add(mesto.Id(),radi);
            }
            dataGridView1.DataSource = mesta;
        }

        private void CreateTable()
        {
            mesta.Columns.Add("Mesto");
            mesta.Columns.Add("Radi");
        }

        private void popravi_btn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                (NaplatnoMesto pokvarenoMesto,int poz)=stanica.FindMesto(GetSelected());
                pokvarenoMesto.setRadi(true);
                stanica.EditMesto(pokvarenoMesto,poz);
                MessageBox.Show("Naplatno mesto " + pokvarenoMesto.Id() + " je popravljeno");
            }
        }

        string GetSelected()
        {
            return dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
