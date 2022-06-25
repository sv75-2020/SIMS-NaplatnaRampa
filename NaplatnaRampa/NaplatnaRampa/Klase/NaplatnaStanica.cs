using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplatnaRampa
{
    public class NaplatnaStanica
    {
        private int id;
        private string lokacija;
        public List<NaplatnoMesto> naplatnaMesta;

        public NaplatnaStanica(int id, string lokacija)
        {
            this.id = id;
            this.lokacija = lokacija;
        }

    }
}
