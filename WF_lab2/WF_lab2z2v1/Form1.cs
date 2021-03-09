using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab2z2v1
{
    public partial class WF_lab2z2v1 : Form
    {
        public WF_lab2z2v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n, i;
            n = Convert.ToInt32(textBox1.Text);

            i = 0;

            if (n == 0)
            {
                i += 1;
            }
            else if (n > 0)
            {
                while (n > 0)
                {
                    n = n / 10;
                    i += 1;
                }
            }
            else
            {
                if (n == -1)
                {
                    i += 1;
                }
                else
                {
                    while (n < -1)
                    {
                        n = n / 10;
                        i += 1;
                    }
                }
            }

            textBox2.Text = i.ToString();
        }
    }
}
