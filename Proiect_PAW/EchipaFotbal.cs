using System;
using System.Collections.Generic;
using System.Drawing;

namespace Proiect_PAW
{
    [Serializable]
    public class EchipaFotbal : Echipa,ICloneable,IComparable
    {
        private List<JucatorFotbal> jucatoriEchipa;
        private string numeStadion;
        public List<JucatorFotbal> JucatoriEchipa { get=>jucatoriEchipa; }
        public string NumeStadion { get=>numeStadion; }
        public EchipaFotbal(string numeEchipa, List<JucatorFotbal> jucatoriEchipa,
            string numeStadion) : base(numeEchipa)
        {
            this.jucatoriEchipa = jucatoriEchipa;
            this.numeStadion = numeStadion;
        }
        public void adaugaJucator(JucatorFotbal jucator)
        {
            JucatoriEchipa.Add(jucator);
        }
        public bool verificareNumarTitulari()
        {
            int count = 0;
            foreach(JucatorFotbal j in JucatoriEchipa)
            {
                if (j.IsTitular) count++;
            }
            if (count != 11) return false;
            return true;
        }
        public override string ToString()
        {
            return NumeEchipa;
        }
        public string raportEchipa()
        {
            String rez=String.Empty;
            rez += NumeEchipa + Environment.NewLine;
            rez += "Stadion: " + numeStadion + Environment.NewLine;
            rez += "Jucatori titulari: " + Environment.NewLine;
            foreach(JucatorFotbal j in this.jucatoriEchipa)
            {
                if (j.IsTitular) rez += j.Nume + Environment.NewLine;
            }
            rez += "Rezerve: " + Environment.NewLine;
            foreach (JucatorFotbal j in this.jucatoriEchipa)
            {
                if (!j.IsTitular) rez += j.Nume + Environment.NewLine;
            }
            return rez;
        }

        public object Clone()
        {
            EchipaFotbal copie = this.MemberwiseClone() as EchipaFotbal;
            copie.jucatoriEchipa = new List<JucatorFotbal>();
            foreach(JucatorFotbal j in jucatoriEchipa)
            {
                copie.jucatoriEchipa.Add(j.Clone() as JucatorFotbal);
            }
            return copie;
        }

        public int CompareTo(object obj)
        {
            return numeStadion.CompareTo((obj as EchipaFotbal).numeStadion);
        }
    }



}
