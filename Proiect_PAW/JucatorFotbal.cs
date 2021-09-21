using System;

namespace Proiect_PAW
{
    [Serializable]
    public class JucatorFotbal : Jucator,ICloneable,IComparable
    {
        private int numarGoluri, numarPaseDeGol;
        private bool isTitular;
        public int NumarGoluri { get=>numarGoluri; }
        public int NumarPaseDeGol { get=>numarPaseDeGol; }

        public bool IsTitular { get=>isTitular; }
        public JucatorFotbal(string nume, int numar, int numarg, int numarpase, bool titular):base(nume,numar)
        {
            this.numarGoluri = numarg;
            this.numarPaseDeGol = numarpase;
            this.isTitular = titular;
        }
        public void daGol()
        {
            numarGoluri++;
        }
        public void daPasaDeGol()
        {
            numarPaseDeGol++;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(object obj)
        {
            return numarGoluri.CompareTo((obj as JucatorFotbal).numarGoluri);
        }

        public static JucatorFotbal operator++(JucatorFotbal j)
        {
            j.numarGoluri++;
            return j;
        }

        public static bool operator<(JucatorFotbal j1, JucatorFotbal j2)
        {
            return j1.numarGoluri < j2.numarGoluri;
        }

        public static bool operator >(JucatorFotbal j1, JucatorFotbal j2)
        {
            return j1.numarGoluri > j2.numarGoluri;
        }
    }


}
