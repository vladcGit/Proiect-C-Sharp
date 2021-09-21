using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormAdaugaMeci : Form
    {
        public MeciFotbal Meci { get; set; }
        private List<EchipaFotbal> listCopy;
        public FormAdaugaMeci(List<EchipaFotbal> lista)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E4F9F5");
            listCopy = lista;
            foreach(EchipaFotbal e in listCopy)
            {
                cbGazda.Items.Add(e.NumeEchipa.ToString());
                cbOaspete.Items.Add(e.NumeEchipa.ToString());
            }
        }

        private void cbOaspete_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbGazda.SelectedIndex==cbOaspete.SelectedIndex)
            {
                cbGazda.SelectedIndex = -1;
                cbOaspete.SelectedIndex = -1;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            //verificari
            errorProvider1.Clear();
            if (String.IsNullOrWhiteSpace(cbGazda.Text)) errorProvider1.SetError(cbGazda, "Selectati o optiune");
            else if (String.IsNullOrWhiteSpace(cbOaspete.Text)) errorProvider1.SetError(cbOaspete, "Selectati o optiune");
            else
            {
                //creare propriu-zisa meci
                Meci = new MeciFotbal(dateTimePicker1.Value,
                    listCopy[cbGazda.SelectedIndex].NumeStadion,
                    listCopy[cbGazda.SelectedIndex].NumeEchipa,
                    listCopy[cbOaspete.SelectedIndex].NumeEchipa);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
