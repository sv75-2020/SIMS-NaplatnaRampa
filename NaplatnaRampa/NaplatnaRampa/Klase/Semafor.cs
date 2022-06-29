namespace NaplatnaRampa
{
    public class Semafor
    {
        private bool semaforRadi;

        public Semafor(bool semaforRadi)
        {
            this.semaforRadi = semaforRadi;
        }

        public string RadiDaNe()
        {
            if (semaforRadi)
                return "Da";
            return "Ne";
        }

        public void setRadi(bool radi)
        {
            this.semaforRadi = radi;
        }

    }
}