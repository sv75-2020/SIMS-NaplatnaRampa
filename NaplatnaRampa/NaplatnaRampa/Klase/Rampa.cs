namespace NaplatnaRampa
{
    public class Rampa
    {
        private bool rampaRadi;

        public Rampa(bool rampaRadi)
        {
            this.rampaRadi = rampaRadi;
        }

        public string RadiDaNe()
        {
            if (rampaRadi)
                return "Da";
            return "Ne";
        }

        public void setRadi(bool radi)
        {
            this.rampaRadi = radi;
        }
    }
}