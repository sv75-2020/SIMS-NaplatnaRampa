using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace NaplatnaRampa
{
    class Aplikacija
    {
        public List<NaplatnaStanica> naplatneStanice = new List<NaplatnaStanica>();

        public Aplikacija()
        {
            LoadNaplatneStanice("../../Data/naplatneStanice.txt");
        }

        public void LoadNaplatneStanice(string fileName)
        {
            string[] lines = File.ReadAllLines(fileName);

            foreach (string line in lines)
            {
                string[] data = line.Split('|');
                NaplatnaStanica naplatnaStanica = new NaplatnaStanica(Int32.Parse(data[0]), data[1]);
                naplatneStanice.Add(naplatnaStanica);
            }
        }

    }
}
