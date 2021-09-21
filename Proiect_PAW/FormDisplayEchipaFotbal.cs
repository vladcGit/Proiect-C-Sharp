using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormDisplayEchipaFotbal : Form
    {
        public FormDisplayEchipaFotbal(EchipaFotbal echipa)
        {
            
            InitializeComponent();
            this.Size = pbTeren.Image.Size;
            tbNumeEchipa.Text = echipa.NumeEchipa;


            List<JucatorFotbal> jucatori = new List<JucatorFotbal>();
            foreach(JucatorFotbal j in echipa.JucatoriEchipa)
            {
                if (j.IsTitular) jucatori.Add(j);
            }

            tbPortar.Text = jucatori[0].Nume;
            tbFundasDreapta.Text = jucatori[1].Nume;
            tbFundasCentralDreapta.Text = jucatori[2].Nume;
            tbFundasCentralStanga.Text = jucatori[3].Nume;
            tbFundasStanga.Text = jucatori[4].Nume;

            tbRCM.Text = jucatori[5].Nume;
            tbCM.Text = jucatori[6].Nume;
            tbLCM.Text = jucatori[7].Nume;

            tbRW.Text = jucatori[8].Nume;
            tbST.Text = jucatori[9].Nume;
            tbLW.Text = jucatori[10].Nume;

            ArrayList labels = new ArrayList();
            labels.Add(lblPortar);
            labels.Add(lblRB);
            labels.Add(lblRCB);
            labels.Add(lblLCB);
            labels.Add(lblLB);
            labels.Add(lblRCM);
            labels.Add(lblCM);
            labels.Add(lblLCM);
            labels.Add(lblRW);
            labels.Add(lblST);
            labels.Add(lblLW);

            for (int i = 0; i < 11; i++)
            {
                (labels[i] as Label).Parent = pbTeren;
                (labels[i] as Label).BackColor = Color.Transparent;
                int nr = jucatori[i].Numar;
                string aux=(nr<10)?" "+nr.ToString():nr.ToString();
                (labels[i] as Label).Text = aux;

            }

            
        }


    }
}
