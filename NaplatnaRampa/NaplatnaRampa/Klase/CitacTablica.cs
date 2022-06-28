using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplatnaRampa.Klase
{
    class CitacTablica
    {
        NaplatnoMesto naplatnoMesto;
        static Random rnd = new Random();

        public string ocitajTablicu()
        {
            var gradovi = new List<string> { "BG", "NS", "SU", "ZR", "LE" };
            int index = rnd.Next(gradovi.Count);
            string tablica = gradovi[index];
            tablica+=rnd.Next(1, 3);
            zapamtiTablicu(tablica);
            return tablica;
        }

        private void zapamtiTablicu(string tablica)
        {
            
        }
    }
}
