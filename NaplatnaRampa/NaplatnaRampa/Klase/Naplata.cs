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
        private int idRadnika;
        public Naplata(int id,TipVozila tipVozila,string deonica, bool evri,DateTime vremeNaplate,DateTime vremeUlaska,string tablica,float iznos,int idStanice, int idRadnika)
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
            this.idRadnika = idRadnika;
        }

        public bool proveraProsecneBrzine()
        {
            TimeSpan vreme = vremeNaplate - vremeUlaska;
            return Aplikacija.deonice[deonica] / (vreme.TotalMinutes / 60) > 120;
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

        public float izracunajCenu()
        {
            float km = Aplikacija.aktivniCenovnik.CenaPoKm();
            Dictionary<TipVozila, float> cenaPoTipu = Aplikacija.aktivniCenovnik.CenaPoTipu();
            float q = cenaPoTipu[tipVozila];
            if (evri)
                return q * km / 117;
            return q * km;
        }

    }
}
