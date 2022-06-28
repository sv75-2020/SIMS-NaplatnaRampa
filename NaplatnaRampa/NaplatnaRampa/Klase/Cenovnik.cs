using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplatnaRampa.Klase
{
    public class Cenovnik
    {
        private DateTime pocetak;
        private DateTime kraj;
        private float cenaPoKm;
        private Dictionary<TipVozila, float> cenaPoTipu = new Dictionary<TipVozila, float>();

        public Cenovnik()
        {

        }
        public Cenovnik(DateTime pocetak,DateTime kraj,float cena)
        {
            this.pocetak = pocetak;
            this.kraj = kraj;
            this.cenaPoKm = cena;
        }

        public void LoadCenaPoTipu(string[] vrednosti)
        {
            int i = 0;
            foreach (TipVozila tip in (TipVozila[])Enum.GetValues(typeof(TipVozila)))
            {
                cenaPoTipu.Add(tip, float.Parse(vrednosti[i]));
                i++;
            }
        }

        public DateTime Pocetak()
        {
            return pocetak;
        }
        public DateTime Kraj()
        {
            return kraj;
        }

        public float CenaPoKm()
        {
            return cenaPoKm;
        }
        public Dictionary<TipVozila, float> CenaPoTipu() {
            return cenaPoTipu;
        }
    }
}
