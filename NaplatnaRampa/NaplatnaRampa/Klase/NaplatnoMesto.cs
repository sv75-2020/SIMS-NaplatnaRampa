using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NaplatnaRampa.Klase;

namespace NaplatnaRampa
{
    public class NaplatnoMesto
    {
        public int id;
        public List<string> tablice = new List<string>();
        public bool elektronsko;
        public List<Naplata> naplate = new List<Naplata>();
        public NaplatnaStanica stanica;
        private bool radi;
        public CitacTablica citacTablica;
        public Rampa rampa;
        public Semafor semafor;
        public CitacTaga citacTaga;

        public NaplatnoMesto(int id,bool elektronsko,NaplatnaStanica stanica,bool radi, bool citacTabliceRadi, bool rampaRadi, bool semaforRadi, bool citacTagaRadi)
        {
            this.id = id;
            this.elektronsko = elektronsko;
            this.stanica = stanica;
            this.radi = radi;
            LoadNaplate("../../Data/naplate.txt");
            citacTablica = new CitacTablica(stanica.id, id, citacTabliceRadi);
            citacTaga = new CitacTaga(citacTagaRadi);
            semafor = new Semafor(semaforRadi);
            rampa = new Rampa(rampaRadi);

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
                    Naplata naplata = new Naplata(Int32.Parse(data[0]), tip, data[2], evri, DateTime.Parse(data[4]), DateTime.Parse(data[5]), data[6], float.Parse(data[7]), Int32.Parse(data[8]), Int32.Parse(data[9]));
                    naplate.Add(naplata);
                }

            }
        }

        public int Id()
        {
            return id;
        }

        public bool Radi()
        {
            return radi;
        }

        public void setRadi(bool radi)
        {
            this.radi = radi;
        }
        public string newId()
        {
            string id = "";
            string[] lines = File.ReadAllLines("../../Data/naplate.txt");

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                id = data[0];
            }
            return (Int32.Parse(id)+1).ToString();
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
