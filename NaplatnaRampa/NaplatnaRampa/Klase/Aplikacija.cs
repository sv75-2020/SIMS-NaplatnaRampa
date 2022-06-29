using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NaplatnaRampa.Klase;
using System.Windows.Forms;

namespace NaplatnaRampa
{
    public enum TipVozila { Auto, Kamion, Autobus };
    public static class Aplikacija
    {
        public static int userId;
        public static List<NaplatnaStanica> naplatneStanice = new List<NaplatnaStanica>();
        public static string fileName= "../../Data/naplatneStanice.txt";
        public static Cenovnik aktivniCenovnik;

        internal static Form login()
        {
            return new LoginForm();
        }

        public static Dictionary<string,float> deonice=new Dictionary<string,float>();

        static Aplikacija()
        {
            LoadNaplatneStanice();
            LoadMesta();
            LoadCenovnik();
            LoadDeonice();
        }

        public static void LoadNaplatneStanice()
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                NaplatnaStanica naplatnaStanica = new NaplatnaStanica(Int32.Parse(data[0]), data[1]);
                naplatneStanice.Add(naplatnaStanica);
            }
        }

        public static void LoadDeonice()
        {
            string[] lines = File.ReadAllLines("../../Data/deonice.txt");

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                deonice.Add(data[0], float.Parse(data[1]));
            }
        }

        public static void LoadCenovnik()
        {
            string[] lines = File.ReadAllLines("../../Data/cenovnik.txt");

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                if (DateTime.Parse(data[1]) > DateTime.Now)
                {
                    string[] cene = data[3].Split(',');
                    aktivniCenovnik = new Cenovnik(DateTime.Parse(data[0]), DateTime.Parse(data[1]), float.Parse(data[2]));
                    aktivniCenovnik.LoadCenaPoTipu(cene);
                }
            }
        }

        private static void LoadMesta()
        {
            foreach(NaplatnaStanica stanica in naplatneStanice)
            {
                stanica.LoadMesta();
            }
        }
        public static NaplatnaStanica FindStanica(string id)
        {
            foreach (NaplatnaStanica stanica in naplatneStanice) {
                if (Int32.Parse(id) == stanica.Id())
                {
                    return stanica;
                }
                    
            }
            return null;
        }

        public static void AddStanica(NaplatnaStanica stanica)
        {
            naplatneStanice.Add(stanica);
            AddStanicaToFile(stanica);
            
        }

        public static void AddStanicaToFile(NaplatnaStanica stanica)
        {
            using (StreamWriter tw = File.AppendText(fileName))
            {
                string line = stanica.id + "|" + stanica.lokacija;
                tw.WriteLine(line);
                tw.Close();
            }
        }

        public static int GetNewId()
        {
            int lastId = naplatneStanice.Last().id;
            return lastId + 1;
        }

        public static void RemoveStanicaFromFile(NaplatnaStanica stanica)
        {
            naplatneStanice.Remove(stanica);
            TextWriter tw = new StreamWriter(fileName);
            foreach(NaplatnaStanica napStanica in naplatneStanice)
            {
                if (napStanica.id != stanica.id)
                {
                    string line = napStanica.id.ToString() + "|" + napStanica.lokacija;
                    tw.WriteLine(line);
                }
            }
            tw.Close();
        }
    }
}
