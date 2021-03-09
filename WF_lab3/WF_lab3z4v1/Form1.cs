using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab3z4v1
{
    public partial class WF_lab3z4v1 : Form
    {
        public WF_lab3z4v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] d = textBox1.Text.Split(' ');
            double[] x = new double[d.Length];
            for (int i = 0; i < d.Length; i++)
            {
                x[i] = Convert.ToDouble(d[i]);
            }

            Array.Sort(x);

            for (int i = 0; i < d.Length; i++)
            {
                sort.Items.Add(x[i]);
            }
        }
    }
}
