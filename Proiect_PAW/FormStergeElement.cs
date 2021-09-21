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
    public partial class FormStergeElement : Form
    {
        public int Index { get; set; }
        ArrayList copie;
        public FormStergeElement(ArrayList lista)
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E4F9F5");
            copie = lista;
            foreach(object o in lista)
            {
                comboBox1.Items.Add(o.ToString());
            }
            Index = -1;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 0)
            {
                Index = comboBox1.SelectedIndex;
            }
        }
    }
}
