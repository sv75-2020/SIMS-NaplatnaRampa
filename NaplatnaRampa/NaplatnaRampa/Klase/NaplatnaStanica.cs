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
        public int id;
        public string lokacija;
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
                bool radi = false;
                if (data[1] == "true")
                    elektronsko = true;
                if (data[3] == "true")
                    radi = true;
                Enum.TryParse<TipVozila>(data[1], out TipVozila tip);
                if (data[2] == id.ToString())
                {
                    NaplatnoMesto mesto = new NaplatnoMesto(Int32.Parse(data[0]), elektronsko, Aplikacija.FindStanica(data[2]),radi);
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

        public (NaplatnoMesto, int) FindMesto(string id)
        {
            int pozicija = 0;
            foreach (NaplatnoMesto mesto in naplatnaMesta)
            {
                pozicija++;
                if (Int32.Parse(id) == mesto.Id())
                {
                    return (mesto, pozicija);
                    break;
                }

            }
            return (null, 0);
        }

        public void AddMesto(NaplatnoMesto mesto)
        {
            naplatnaMesta.Add(mesto);
            AddMestoToFile(mesto);
        }

        public void AddMestoToFile(NaplatnoMesto mesto)
        {
            using (StreamWriter tw = File.AppendText(fileName))
            {
                string line = mesto.id + "|" + mesto.elektronsko.ToString().ToLower() + "|" + mesto.stanica.id.ToString()+"|"+mesto.Radi().ToString();
                tw.WriteLine(line);
                tw.Close();
            }
        }

        public int GetNewId()
        {
            string[] lines = File.ReadAllLines(fileName);
            string[] lastLine = lines[lines.Length - 1].Split('|');
            return Int32.Parse(lastLine[0]) + 1;
        }

        public void RemoveMestoFromFile(NaplatnoMesto mesto, int poz)
        {
            var tempFile = Path.GetTempFileName();
            var linesToKeep = File.ReadLines(fileName).Where(l => l.Split('|')[0] != mesto.id.ToString() + "|" + mesto.Radi().ToString());

            File.WriteAllLines(tempFile, linesToKeep);

            File.Delete(fileName);
            File.Move(tempFile, fileName);
        }

        public void EditMesto(NaplatnoMesto mesto, int poz)
        {
            if (mesto.elektronsko)
            {
                mesto.elektronsko = false;
            } else
            {
                mesto.elektronsko = true;
            }

            string newLine = mesto.id.ToString() + "|" + mesto.elektronsko.ToString().ToLower() + "|" + mesto.stanica.id.ToString() + "|" + mesto.Radi().ToString();
            
            string[] arrLine = File.ReadAllLines(fileName);
            arrLine[poz - 1] = newLine;
            File.WriteAllLines(fileName, arrLine);
        }
    }
}
