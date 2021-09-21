using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Proiect_PAW
{
    public partial class FormPrincipal : Form
    {
        public List<EchipaFotbal> echipe;
        public List<MeciFotbal> meciuri;
        public FormPrincipal()
        {
            InitializeComponent();

            this.BackColor = ColorTranslator.FromHtml("#E4F9F5");
            listView1.BackColor = ColorTranslator.FromHtml("#30E3CA");
            menuStrip1.BackColor = this.BackColor;
            statusStrip1.BackColor = this.BackColor;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnPrevDay_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        private void btnNextDay_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        #region CRUD
        private void Form1_Load(object sender, EventArgs e)
        {
            //citire echipe si meciuri din fisier la startup

            deserializeToolStripMenuItem_Click(null, EventArgs.Empty);
            foreach (EchipaFotbal ech in echipe)
            {
                cbEchipe.Items.Add(ech.NumeEchipa);
            }

            dateTimePicker1.Value = DateTime.Today;
        }

        //Se salveaza datele la iesirea din aplicatie
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveToolStripMenuItem_Click(sender, EventArgs.Empty);
        }

        private void adaugaEchipaBtn_Click(object sender, EventArgs e)
        {
            FormAdaugaEchipa frm = new FormAdaugaEchipa();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //frm este proprietatea din FormAdaugaEchipa prin care se transmit datele
                echipe.Add(frm.ValoareEchipa);
                cbEchipe.Items.Add(echipe[echipe.Count - 1]);
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //display echipa selectata
        private void cbEchipe_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormDisplayEchipaFotbal frm = new FormDisplayEchipaFotbal(echipe[cbEchipe.SelectedIndex]);
            frm.ShowDialog();
        }

        //mereu cand se modifica data se reactualizeaza listview-ul
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            foreach (MeciFotbal m in meciuri)
            {
                if (m.DataMeci.Date != dateTimePicker1.Value.Date) continue;
                ListViewItem itm = new ListViewItem(m.EchipaGazda);
                itm.SubItems.Add(m.EchipaOaspete);
                itm.SubItems.Add(m.Locatie);
                if (listView1.Items.Count % 2 == 0) itm.BackColor = ColorTranslator.FromHtml("#3E92A3");

                listView1.Items.Add(itm);
            }
        }
        #endregion

        #region MenuStrip si ContextMenuStrip
        //Salvare explicita date
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fis = new FileStream("echipe.dat", FileMode.Open);
            BinaryFormatter fmt = new BinaryFormatter();
            fmt.Serialize(fis, echipe);
            fis.Close();

            fis = new FileStream("meciuri.dat", FileMode.Open);
            fmt.Serialize(fis, meciuri);
            fis.Close();
        }

        private void deserializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string caleAbsoluta = System.IO.Directory.GetCurrentDirectory() + "\\echipe.dat";
            if (File.Exists(caleAbsoluta) && new FileInfo(caleAbsoluta).Length != 0)
            {
                FileStream fis = new FileStream("echipe.dat", FileMode.Open);
                BinaryFormatter fmt = new BinaryFormatter();
                echipe = (List<EchipaFotbal>)fmt.Deserialize(fis);
                fis.Close();
            }
            else
            {
                FileStream fis = new FileStream("echipe.dat", FileMode.Create);
                fis.Close();
                echipe = new List<EchipaFotbal>();
            }

            caleAbsoluta = System.IO.Directory.GetCurrentDirectory() + "\\meciuri.dat";
            if (File.Exists(caleAbsoluta) && new FileInfo(caleAbsoluta).Length != 0)
            {
                FileStream fis = new FileStream("meciuri.dat", FileMode.Open);
                BinaryFormatter fmt = new BinaryFormatter();
                meciuri = (List<MeciFotbal>)fmt.Deserialize(fis);
                fis.Close();
            }
            else
            {
                FileStream fis = new FileStream("meciuri.dat", FileMode.Create);
                fis.Close();
                meciuri = new List<MeciFotbal>();
            }
        }

        private void adaugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            adaugaEchipaBtn.PerformClick();
        }

        private void adaugaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAdaugaMeci frm = new FormAdaugaMeci(echipe);
            if (frm.ShowDialog() == DialogResult.OK) meciuri.Add(frm.Meci);
            if (meciuri.Count > 0) dateTimePicker1.Value = meciuri[meciuri.Count - 1].DataMeci;
        }

        private void stergeToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormStergeElement frm = new FormStergeElement(new ArrayList(meciuri));
            if (frm.ShowDialog() == DialogResult.OK && frm.Index >= 0)
            {
                DateTime dt = meciuri[frm.Index].DataMeci;
                meciuri.RemoveAt(frm.Index);
                dateTimePicker1.Value = dt;
            }
        }

        private void stergeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormStergeElement frm = new FormStergeElement(new ArrayList(echipe));
            if (frm.ShowDialog() == DialogResult.OK && frm.Index >= 0)
            {
                echipe.RemoveAt(frm.Index);
                cbEchipe.Items.RemoveAt(frm.Index);
            }
        }

        private void vizualizareListaCompletaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mesaj = "";
            foreach (MeciFotbal m in meciuri)
            {
                mesaj += m.ToString() + "\n";
            }
            MessageBox.Show(mesaj, "Lista completa de meciuri din baza de date",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //refolosesc form-ul de adauga meci pentru modificare
        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem itm = listView1.SelectedItems[0];
                int index = -1;
                foreach (MeciFotbal m in meciuri)
                {
                    if (m.EchipaGazda.Equals(itm.SubItems[0].Text) &&
                        m.EchipaOaspete.Equals(itm.SubItems[1].Text) &&
                        m.DataMeci.Date.Equals(dateTimePicker1.Value.Date))
                    {
                        index = meciuri.IndexOf(m);
                        break;
                    }
                }
                if (index >= 0)
                {
                    FormAdaugaMeci frm = new FormAdaugaMeci(echipe);
                    frm.btnAdauga.Text = "Modifica";
                    frm.Text = "Form modificare meci";
                    if (frm.ShowDialog() == DialogResult.OK) meciuri[index] = frm.Meci;
                    dateTimePicker1.Value = meciuri[index].DataMeci;
                }
                else throw new ArgumentException();
            }
            else MessageBox.Show("Selectati un meci de modificat", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void schimbaCuloareFundalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK) this.BackColor = dlg.Color;
        }
        //salvare in fisier text meciuri din ziua selectata
        private void listaMeciuriDintroZiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Title = "Salvare raport";
            saveFileDialog1.Filter = "Fisier text (*.txt)|*.txt";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
                foreach (MeciFotbal m in meciuri)
                {
                    if (m.DataMeci.Date.Equals(dateTimePicker1.Value.Date)) sw.WriteLine(m);
                }
                sw.Close();
                MessageBox.Show("Salvare cu succes");
            }
        }

        //refolosesc form-ul de sterge echipa pentru selectie
        private void informatiiDespreEchipaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStergeElement frm = new FormStergeElement(new ArrayList(echipe));
            frm.Text = "Form selectare echipa";
            frm.btnSterge.Text = "Selecteaza";
            if (frm.ShowDialog() == DialogResult.OK && frm.Index >= 0)
            {
                EchipaFotbal temp = echipe[frm.Index];
                StreamWriter sw = new StreamWriter(temp.NumeEchipa + ".txt");
                sw.Write(temp.raportEchipa());
                sw.Close();
            }
        }
        private void exportXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //preluare meciuri din data respectiva
            List<MeciFotbal> meciuriData = new List<MeciFotbal>();
            foreach (MeciFotbal m in meciuri)
            {
                if (m.DataMeci.Date.Equals(dateTimePicker1.Value.Date)) meciuriData.Add(m);
            }

            MemoryStream stream = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(stream, Encoding.UTF8);
            writer.Formatting = Formatting.Indented;

            writer.WriteStartDocument();

            writer.WriteStartElement("Meciuri");
            writer.WriteStartElement(dateTimePicker1.Value.ToShortDateString());
            foreach (MeciFotbal m in meciuriData)
            {
                writer.WriteStartElement(m.EchipaGazda + "-" + m.EchipaOaspete);
                writer.WriteStartElement("Jucatori_Gazde");
                writer.WriteStartElement("Titulari");
                EchipaFotbal gazde = echipe.Find(x => x.NumeEchipa.Equals(m.EchipaGazda));
                foreach (JucatorFotbal jucator in gazde.JucatoriEchipa)
                {
                    if (jucator.IsTitular)
                    {
                        writer.WriteStartElement(jucator.Nume.Split(' ')[0]);
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();

                writer.WriteStartElement("Rezerve");
                foreach (JucatorFotbal jucator in gazde.JucatoriEchipa)
                {
                    if (!jucator.IsTitular)
                    {
                        writer.WriteStartElement(jucator.Nume.Split(' ')[0]);
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();

                writer.WriteEndElement();

                writer.WriteStartElement("Jucatori_Oaspeti");
                writer.WriteStartElement("Titulari");
                EchipaFotbal oaspeti = echipe.Find(x => x.NumeEchipa.Equals(m.EchipaOaspete));
                foreach (JucatorFotbal jucator in oaspeti.JucatoriEchipa)
                {
                    if (jucator.IsTitular)
                    {
                        writer.WriteStartElement(jucator.Nume.Split(' ')[0]);
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();

                writer.WriteStartElement("Rezerve");
                foreach (JucatorFotbal jucator in oaspeti.JucatoriEchipa)
                {
                    if (!jucator.IsTitular)
                    {
                        writer.WriteStartElement(jucator.Nume.Split(' ')[0]);
                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();

                writer.WriteEndElement();
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteEndDocument();

            writer.Close();
            String text = Encoding.UTF8.GetString(stream.ToArray());
            stream.Close();

            StreamWriter sw = new StreamWriter("fisier.xml");
            sw.WriteLine(text);
            sw.Close();
        }

        #endregion

        #region Grafic si Print preview
        private void graficulMeciurilorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> listaNume = new List<string>();
            List<int> listaNumere = new List<int>();
            foreach (EchipaFotbal ech in echipe)
            {
                listaNume.Add(ech.NumeEchipa);
                listaNumere.Add(0);
            }
            for (int i = 0; i < listaNume.Count; i++)
            {
                foreach (MeciFotbal m in meciuri)
                {
                    if (m.EchipaGazda == listaNume[i] || m.EchipaOaspete == listaNume[i]) listaNumere[i]++;
                }
            }
            FormGraficMeciuri frm = new FormGraficMeciuri(listaNume, listaNumere);
            frm.Show();
        }

        #endregion

        #region Clipboard si DragDrop
        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedIndices.Count == 0) return;
            ListViewItem itm = listView1.Items[listView1.SelectedIndices[0]];
            string echipaGazda = itm.SubItems[0].Text;
            string echipaOaspete = itm.SubItems[1].Text;
            string locatie = itm.SubItems[2].Text;
            string dataMeci = dateTimePicker1.Value.ToShortDateString();
            string text = $"{echipaGazda} - {echipaOaspete} {dataMeci} {locatie}";
            if (text != null) listView1.DoDragDrop(text, DragDropEffects.Copy);
        }

        private void copiazaInClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0) return;
            string text = String.Empty;
            foreach (ListViewItem itm in listView1.SelectedItems)
            {
                string echipaGazda = itm.SubItems[0].Text;
                string echipaOaspete = itm.SubItems[1].Text;
                string locatie = itm.SubItems[2].Text;
                string dataMeci = dateTimePicker1.Value.ToShortDateString();
                text += $"{echipaGazda} - {echipaOaspete} {dataMeci} {locatie}" + Environment.NewLine;
            }

            Clipboard.SetDataObject(text);
        }

        #endregion

    }
}
