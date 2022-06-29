namespace NaplatnaRampa
{
    public class CitacTaga
    {
        private bool radi;

        public CitacTaga(bool radi)
        {
            this.radi = radi;
        }

        public string RadiDaNe()
        {
            if (radi)
                return "Da";
            return "Ne";
        }

        public void setRadi(bool radi)
        {
            this.radi = radi;
        }
    }
}