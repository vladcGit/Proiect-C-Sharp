using System;

namespace Proiect_PAW
{
    [Serializable]
    public abstract class Jucator
    {
        private string nume;
        private int numar;
        public string Nume { get=>nume; }
        public int Numar { get=>numar; }
        public Jucator(string nume, int numar)
        {
            this.nume = nume;
            this.numar = numar;
        }
    }


}
