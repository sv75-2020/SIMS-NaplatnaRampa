using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NaplatnaRampa
{
    public class NaplatnaStanica
    {
        private int id;
        private string lokacija;
        public List<NaplatnoMesto> naplatnaMesta = new List<NaplatnoMesto>();
        public string fileName = "../../Data/naplatnaMesta.txt";

        public NaplatnaStanica(int id, string lokacija)
        {
            this.id = id;
            this.lokacija = lokacija;
            
        }
        public void LoadMesta()
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                bool elektronsko = false;
                if (data[1] == "true")
                    elektronsko = true;
                Enum.TryParse<TipVozila>(data[1], out TipVozila tip);
                if (data[2] == id.ToString())
                {
                    NaplatnoMesto mesto = new NaplatnoMesto(Int32.Parse(data[0]), elektronsko, Aplikacija.FindStanica(data[2]));
                    naplatnaMesta.Add(mesto);
                }
            }
        }

       public int Id()
        {
            return id;
        }

        public float stampajIzvestaj(DateTime pocetak, DateTime kraj) {
            float zarada = 0;
            foreach(NaplatnoMesto mesto in naplatnaMesta)
            {
                zarada += mesto.zarada(pocetak, kraj);
            }
            return zarada;
        }
    }
}
