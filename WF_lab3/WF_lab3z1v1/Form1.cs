using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab3z1v1
{
    public partial class WF_lab3z1v1 : Form
    {
        public WF_lab3z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double s = 0;

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                s += Convert.ToDouble(array_DG[i, 0].Value);
            }
            s = s / (int)numericUpDown1.Value;
            textBox3.Text = s.ToString();
        }

        private void WF_lab3z1v1_Load(object sender, EventArgs e)
        {
            array_DG.RowCount = 1;
            array_DG.ColumnCount = 1;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            array_DG.ColumnCount = (int)numericUpDown1.Value;
        }
    }
}
