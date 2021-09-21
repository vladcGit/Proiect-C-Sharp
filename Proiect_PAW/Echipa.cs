using System;
using System.Drawing;

namespace Proiect_PAW
{
    [Serializable]
    public abstract class Echipa
    {
        private string numeEchipa;
        public string NumeEchipa { get=>numeEchipa; }
        public Echipa(string numeEchipa)
        {
            this.numeEchipa = numeEchipa;
        }
    }


}
