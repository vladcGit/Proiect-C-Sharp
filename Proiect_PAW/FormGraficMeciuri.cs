using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_PAW
{
    public partial class FormGraficMeciuri : Form
    {
        private List<string> listaNume;
        private List<int> listaNumere;

        const int marg = 10;

        Color culoare = ColorTranslator.FromHtml("#30E3CA");
        Color culoareMargine = ColorTranslator.FromHtml("#3E92A3");

        Font font = new Font(FontFamily.GenericMonospace, 12, FontStyle.Bold);
        public FormGraficMeciuri(List<string> listaNume, List<int> listaNumere)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E4F9F5");
            this.listaNume = listaNume;
            this.listaNumere = listaNumere;
            panel1.Invalidate();
        }
        private int paint(Graphics gr)
        {
            Rectangle rec = new Rectangle(this.ClientRectangle.X + marg, this.ClientRectangle.Y + 2 * marg,
                    this.ClientRectangle.Width - 2 * marg, this.ClientRectangle.Height - 5 * marg);
            Pen pen = new Pen(Color.Gray, 3);
            gr.DrawRectangle(pen, rec);
            pen.Color = Color.Red;

            double latime = rec.Width / listaNume.Count / 3;
            double distanta = (rec.Width - listaNume.Count * latime) / (listaNume.Count + 1);
            double elemMax = listaNumere.Max() * 1.35;

            Brush brush = new SolidBrush(Color.Black);

            Rectangle[] recs = new Rectangle[listaNume.Count];

            for (int i = 0; i < listaNume.Count; i++)
            {
                recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                    (int)(rec.Location.Y + rec.Height - listaNumere[i] / elemMax * rec.Height - 4 * marg),
                    (int)latime,
                    (int)(listaNumere[i] / elemMax * rec.Height + 10));

                gr.FillRectangle(new SolidBrush(culoareMargine), recs[i]);

                gr.DrawString(listaNumere[i].ToString(), font, brush,
                    new Point(recs[i].Location.X + (int)latime / 2 - 5, recs[i].Location.Y - font.Height + recs[i].Height / 2));
                gr.DrawString(listaNume[i], font, brush,
                    new Point(recs[i].Location.X - listaNume[i].Length * listaNume.Count / 2,
                        recs[i].Location.Y + recs[i].Height));
            }

            for (int i = 0; i < listaNume.Count - 1; i++)
                gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2), recs[i].Location.Y),
                    new Point((int)(recs[i + 1].Location.X + latime / 2), recs[i + 1].Location.Y));


            gr.DrawString("Numar de meciuri jucate de fiecare echipa",
                new Font(FontFamily.GenericMonospace, 17, (int)FontStyle.Underline + FontStyle.Bold),
                brush, new Point(rec.Location.X + rec.Width / 5, rec.Location.Y + 30));

            return rec.Location.Y + rec.Height;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            paint(gr);
        }

        private void pdPrint(object sender, PrintPageEventArgs e)
        {
            Graphics gr = e.Graphics;
            Brush brush = new SolidBrush(culoare);
            int dist = paint(gr);

            for(int i=0;i<listaNume.Count;i++)
            {
                gr.DrawString(listaNume[i] + ": " + listaNumere[i].ToString() + " meciuri jucate", font, 
                    new SolidBrush(Color.Black), new Point(e.PageBounds.X + 30, dist += font.Height + 20));
            }
        }

        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pdPrint);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();
        }

        private void schimbareCuloareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            { 
                culoareMargine = dlg.Color;
                panel1.Invalidate();
            }
        }

        private void schimbareFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dlg = new FontDialog();
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                font = dlg.Font;
                panel1.Invalidate();
            }
        }
    }
}


