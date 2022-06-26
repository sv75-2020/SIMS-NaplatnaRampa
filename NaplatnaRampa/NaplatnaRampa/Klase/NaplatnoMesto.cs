using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NaplatnaRampa
{
    public class NaplatnoMesto
    {
        private int id;
        private List<String> tablice;
        private bool elektronsko;
        public List<Naplata> naplate = new List<Naplata>();
        private NaplatnaStanica stanica;

        public NaplatnoMesto()
        {
            LoadNaplate("Data/naplate.txt");
        }

        public NaplatnoMesto(int id,bool elektronsko,NaplatnaStanica stanica)
        {
            this.id = id;
            this.elektronsko = elektronsko;
            this.stanica = stanica;
            LoadNaplate("../../Data/naplate.txt");
        }
        public void LoadNaplate(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                bool evri = false; ;
                if (data[3] == "true")
                    evri = true;
                Enum.TryParse<TipVozila>(data[1],out TipVozila tip);
                if (data[8] == id.ToString())
                {
                    Naplata naplata = new Naplata(Int32.Parse(data[0]), tip, data[2], evri, DateTime.Parse(data[4]), DateTime.Parse(data[5]), data[6], float.Parse(data[7]), Int32.Parse(data[8]));
                    naplate.Add(naplata);
                }
            }
        }

        public float zarada(DateTime pocetak,DateTime kraj)
        {
            float zarada = 0;
            foreach(Naplata naplata in naplate)
            {
                if(naplata.Vreme()<kraj && naplata.Vreme() > pocetak)
                {
                    zarada += naplata.Iznos();
                }
            }
            return zarada;
        }
    }
}
