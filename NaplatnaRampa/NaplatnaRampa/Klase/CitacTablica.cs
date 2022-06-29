using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplatnaRampa.Klase
{
    public class CitacTablica
    {
        int idNapMesta;
        int idNapStanice;
        NaplatnoMesto naplatnoMesto;
        static Random rnd;
        bool radi;

        public CitacTablica(int idNapStanice, int idNapMesta, bool citacTabliceRadi)
        {
            this.idNapStanice = idNapStanice;
            this.idNapMesta = idNapMesta;
            rnd = new Random();
            radi = citacTabliceRadi;
        }

        public string ocitajTablicu()
        {
            var gradovi = new List<string> { "BG", "NS", "SU", "ZR", "LE" };
            int index = rnd.Next(gradovi.Count);
            string tablica = gradovi[index];
            tablica += '-';
            tablica+=rnd.Next(1, 10).ToString();
            tablica+=rnd.Next(1, 10).ToString();
            tablica+=rnd.Next(1, 10).ToString();
            zapamtiTablicu(tablica);
            return tablica;
        }

        private void zapamtiTablicu(string tablica)
        {
            if (naplatnoMesto == null)
            {
                NaplatnaStanica stanica = Aplikacija.FindStanica(idNapStanice.ToString());
                (naplatnoMesto, _ )= stanica.FindMesto(idNapMesta.ToString());
            }
            naplatnoMesto.tablice.Add(tablica);
        }

        public string RadiDaNe()
        {
            if (radi)
                return "Da";
            return "Ne";
        }

        public void setRadi(bool radi)
        {
            this.radi = radi;
        }

        public bool getRadi()
        {
            return this.radi;
        }

    }
}
