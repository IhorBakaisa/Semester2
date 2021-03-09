using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab2z4v1
{
    public partial class WF_lab2z4v1 : Form
    {
        public WF_lab2z4v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, n;
            double f, ff;

            n = 10;
            f = 1;
            ff = 0;
            for (i = 1; i <= n; i++)
            {
                ff = f + (2 * i);
                f = ff;
            }

             textBox1.Text = ff.ToString();
        }
    }
}
