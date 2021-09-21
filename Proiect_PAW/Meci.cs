using System;

namespace Proiect_PAW
{
    [Serializable]
    public abstract class Meci
    {
        private DateTime dataMeci;
        private string locatie;
        public DateTime DataMeci { get=>dataMeci; }

        public string Locatie { get=>locatie; }
        public Meci(DateTime dataMeci, string locatie)
        {
            this.dataMeci = dataMeci;
            this.locatie = locatie;
        }
    }



}
