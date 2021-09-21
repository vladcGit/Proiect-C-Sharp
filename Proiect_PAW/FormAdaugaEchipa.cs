using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormAdaugaEchipa : Form
    {
        private EchipaFotbal echipa;
        public FormAdaugaEchipa()
        {
            InitializeComponent();
            //adaugare culori
            groupBox1.BackColor= ColorTranslator.FromHtml("#3E92A3");
            groupBox2.BackColor= ColorTranslator.FromHtml("#40514E");
            this.BackColor = ColorTranslator.FromHtml("#E4F9F5");
            buttonAdauga.BackColor = this.BackColor;
        }
        public EchipaFotbal ValoareEchipa { get => echipa; }

        public bool CreareEchipaFotbal()
        {

            ArrayList tbNumeTitulari = new ArrayList();
            tbNumeTitulari.Add(tbNumeJucatorTitular1);
            tbNumeTitulari.Add(tbNumeJucatorTitular2);
            tbNumeTitulari.Add(tbNumeJucatorTitular3);
            tbNumeTitulari.Add(tbNumeJucatorTitular4);
            tbNumeTitulari.Add(tbNumeJucatorTitular5);
            tbNumeTitulari.Add(tbNumeJucatorTitular6);
            tbNumeTitulari.Add(tbNumeJucatorTitular7);
            tbNumeTitulari.Add(tbNumeJucatorTitular8);
            tbNumeTitulari.Add(tbNumeJucatorTitular9);
            tbNumeTitulari.Add(tbNumeJucatorTitular10);
            tbNumeTitulari.Add(tbNumeJucatorTitular11);

            ArrayList tbNumereTitulari = new ArrayList();
            tbNumereTitulari.Add(tbNumarJucatorTitular1);
            tbNumereTitulari.Add(tbNumarJucatorTitular2);
            tbNumereTitulari.Add(tbNumarJucatorTitular3);
            tbNumereTitulari.Add(tbNumarJucatorTitular4);
            tbNumereTitulari.Add(tbNumarJucatorTitular5);
            tbNumereTitulari.Add(tbNumarJucatorTitular6);
            tbNumereTitulari.Add(tbNumarJucatorTitular7);
            tbNumereTitulari.Add(tbNumarJucatorTitular8);
            tbNumereTitulari.Add(tbNumarJucatorTitular9);
            tbNumereTitulari.Add(tbNumarJucatorTitular10);
            tbNumereTitulari.Add(tbNumarJucatorTitular11);

            ArrayList tbNumeRezerve = new ArrayList();
            tbNumeRezerve.Add(tbNumeJucatorRezerva1);
            tbNumeRezerve.Add(tbNumeJucatorRezerva2);
            tbNumeRezerve.Add(tbNumeJucatorRezerva3);
            tbNumeRezerve.Add(tbNumeJucatorRezerva4);
            tbNumeRezerve.Add(tbNumeJucatorRezerva5);
            tbNumeRezerve.Add(tbNumeJucatorRezerva6);
            tbNumeRezerve.Add(tbNumeJucatorRezerva7);

            ArrayList tbNumereRezerve = new ArrayList();
            tbNumereRezerve.Add(tbNumarJucatorRezerva1);
            tbNumereRezerve.Add(tbNumarJucatorRezerva2);
            tbNumereRezerve.Add(tbNumarJucatorRezerva3);
            tbNumereRezerve.Add(tbNumarJucatorRezerva4);
            tbNumereRezerve.Add(tbNumarJucatorRezerva5);
            tbNumereRezerve.Add(tbNumarJucatorRezerva6);
            tbNumereRezerve.Add(tbNumarJucatorRezerva7);

            //Verificari
            #region
            //verifica nume echipa
            if (String.IsNullOrWhiteSpace(tbNumeEchipa.Text))
            {
                errorProvider1.SetError(tbNumeEchipa, "Introduceti un nume pentru echipa");
                return false;
            }
            //verifica nume stadion
            if (String.IsNullOrWhiteSpace(tbNumeStadion.Text))
            {
                errorProvider1.SetError(tbNumeStadion, "Introduceti un nume pentru echipa");
                return false;
            }
            //verifica nume titulari
            for (int i = 0; i < tbNumeTitulari.Count; i++)
            {
                if (String.IsNullOrWhiteSpace((tbNumeTitulari[i] as TextBox).Text))
                {
                    errorProvider1.SetError(tbNumeTitulari[i] as TextBox, "Introduceti numele jucatorului");
                    return false;
                }
            }
            //verifica numere titulari
            for (int i = 0; i < tbNumereTitulari.Count; i++)
            {
                if (String.IsNullOrWhiteSpace((tbNumereTitulari[i] as TextBox).Text))
                {
                    errorProvider1.SetError(tbNumereTitulari[i] as TextBox, "Introduceti numarul jucatorului");
                    return false;
                }
            }

            //verifica daca o rezerva are doar un singur camp completat dintre nume si numar
            for (int i = 0; i < tbNumeRezerve.Count; i++)
            {
                if (String.IsNullOrWhiteSpace((tbNumeRezerve[i] as TextBox).Text) &&
                    !String.IsNullOrWhiteSpace((tbNumereRezerve[i] as TextBox).Text))
                {
                    errorProvider1.SetError(tbNumeRezerve[i] as TextBox, "Introduceti numele jucatorului");
                    return false;
                }
                if (!String.IsNullOrWhiteSpace((tbNumeRezerve[i] as TextBox).Text) &&
                    String.IsNullOrWhiteSpace((tbNumereRezerve[i] as TextBox).Text))
                {
                    errorProvider1.SetError(tbNumereRezerve[i] as TextBox, "Introduceti numarul jucatorului");
                    return false;
                }
            }
            //verifica daca 2 jucatori au acelasi numar

            //adauga numerele jucatorilor in lista
            List<int> listaNumere = new List<int>();
            for (int i = 0; i < tbNumereTitulari.Count; i++)
            {
                listaNumere.Add(Convert.ToInt32((tbNumereTitulari[i] as TextBox).Text));
            }
            for (int i = 0; i < tbNumereRezerve.Count; i++)
            {
                string x = (tbNumereRezerve[i] as TextBox).Text;
                if (!String.IsNullOrWhiteSpace(x)) listaNumere.Add(Convert.ToInt32(x));
            }
            //verifica valori duplicate in lista de numere
            if (listaNumere.GroupBy(n => n).Any(c => c.Count() > 1))
            {
                MessageBox.Show("Fiecare jucator trebuie sa aiba un nume unic", "Eroare",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return false;
            }
            #endregion

            //Valid
            this.echipa = new EchipaFotbal(tbNumeEchipa.Text,
                new List<JucatorFotbal>(), tbNumeStadion.Text);

            for (int i = 0; i < 11; i++)
            {
                int nr = Int32.Parse((tbNumereTitulari[i] as TextBox).Text);
                string text = (tbNumeTitulari[i] as TextBox).Text;
                JucatorFotbal jucator = new JucatorFotbal(text, nr, 0, 0, true);
                echipa.adaugaJucator(jucator);
            }
            for (int i = 0; i < 7; i++)
            {
                string text = (tbNumeRezerve[i] as TextBox).Text;
                if (text == String.Empty) continue;
                int nr = Int32.Parse((tbNumereRezerve[i] as TextBox).Text);
                JucatorFotbal jucator = new JucatorFotbal(text, nr, 0, 0, false);
                echipa.adaugaJucator(jucator);
            }
            return true;
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (CreareEchipaFotbal())
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void tbNumarJucatorTitular1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
