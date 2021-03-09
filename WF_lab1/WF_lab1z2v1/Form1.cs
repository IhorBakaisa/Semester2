using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab1z2v1
{
    public partial class WF_lab1z2v1 : Form
    {
        public WF_lab1z2v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(textBox1.Text);
            b = Convert.ToDouble(textBox2.Text);

            if (1 <= a && a <= 2 && 1 <= b && b <= 2 || 3 < a && a < 7 && 3 < b && b < 7 || 3 < a && a < 7 && 1 <= b && b <= 2 || 1 <= a && a <= 2 && 3 < b && b < 7)
            {
                textBox3.Text = "Належать";
            }
            else
            {
                textBox3.Text = "Неналежать";
            }
        }
    }
}
