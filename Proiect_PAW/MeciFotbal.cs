using System;

namespace Proiect_PAW
{
    [Serializable]
    public class MeciFotbal : Meci
    {
        private string echipaGazda, echipaOaspete;
        public string EchipaGazda { get=>echipaGazda; }
        public string EchipaOaspete { get=>echipaOaspete; }
        public MeciFotbal(DateTime dataMeci, string locatie, string echipaGazda, string echipaOaspete):base(dataMeci,locatie)
        {
            this.echipaGazda = echipaGazda;
            this.echipaOaspete = echipaOaspete;
        }
        public override string ToString()
        {
            return $"{echipaGazda} - {echipaOaspete} {DataMeci.ToShortDateString()} {Locatie}";
        }
    }
}
