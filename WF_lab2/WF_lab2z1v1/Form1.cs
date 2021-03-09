using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab2z1v1
{
    public partial class WF_lab2z1v1 : Form
    {
        public WF_lab2z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, m, k;
            a = Convert.ToDouble(textBox1.Text);
            int n = Convert.ToInt32(textBox2.Text);

            m = 1;

            for (int i = 0; n > i; i++)
            {
                k = a + i;
                m *= k;
            }

            textBox3.Text = m.ToString();
        }
    }
}
