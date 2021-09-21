using System;
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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime acum = DateTime.Now;
            DateTime dt1 = new DateTime(2021, 5, 29, 14, 24, 0);
            TimeSpan ts = new TimeSpan(0, 0, 20);
            DateTime dt2 = dt1 + ts;

            if (acum.CompareTo(dt1)>0 && acum.CompareTo(dt2)<0)
            {
                tbText.Visible = true;
                label2.Visible = true;
            }
            else
            {
                tbText.Visible = false;
                label2.Visible = false;
            }
        }
    }
}
