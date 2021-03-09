using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab5z3v1
{
    public partial class WF_lab5z3v1 : Form
    {
        private static int f(int i)
        {
            if (i == 1 || i == 2)
            {
                return 1;
            }
            else
            {
                return f(i - 1) + f(i - 2);
            }
        }

        public WF_lab5z3v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int s = f(3) + f(8);
            textBox1.Text = s.ToString();
        }
    }
}
