using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NaplatnaRampa
{
  
   public class Naplata
    {
        private int id;
        private TipVozila tipVozila;
        private string deonica;
        private bool evri;
        private DateTime vremeNaplate;
        private DateTime vremeUlaska;
        private string tablica;
        private float iznos;
        private int idStanice;
        public Naplata(int id,TipVozila tipVozila,string deonica, bool evri,DateTime vremeNaplate,DateTime vremeUlaska,string tablica,float iznos,int idStanice)
        {
            this.id = id;
            this.tipVozila = tipVozila;
            this.deonica = deonica;
            this.evri = evri;
            this.vremeNaplate = vremeNaplate;
            this.vremeUlaska = vremeUlaska;
            this.tablica = tablica;
            this.iznos = iznos;
            this.idStanice = idStanice;
        }

        public DateTime Vreme()
        {
            return vremeNaplate;
        }

        public float Iznos() {
            return iznos;
        }

        public int IdStanice()
        {
            return idStanice;
        }
    }
}
