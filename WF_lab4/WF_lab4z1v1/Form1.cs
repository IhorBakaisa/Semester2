using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab4z1v1
{
    public partial class WF_lab4z1v1 : Form
    {
        public WF_lab4z1v1()
        {
            InitializeComponent();
        }

        private void WF_lab4z1v1_Load(object sender, EventArgs e)
        {
            matrix_DG.RowCount = (int)rowNumber.Value;
            matrix_DG.ColumnCount = (int)colNumber.Value;
        }

        private void rowNumber_ValueChanged(object sender, EventArgs e)
        {
            matrix_DG.RowCount = (int)rowNumber.Value;
        }

        private void colNumber_ValueChanged(object sender, EventArgs e)
        {
            matrix_DG.ColumnCount = (int)colNumber.Value;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < matrix_DG.RowCount; i++)
            {
                for (int j = 0; j < matrix_DG.ColumnCount; j++)
                {
                    matrix_DG[j, i].Value = rand.Next(-100, 100);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int d = 0;
            for (int i = 0; i < matrix_DG.RowCount; i++)
            {
                int c = i + 1;
                for (int j = 0; j < matrix_DG.ColumnCount; j++)
                {
                    int z = j + 1;
                    if (c % 2 == 0 && z % 2 == 0)
                    {
                        if ((int)matrix_DG[j, i].Value < 0)
                            d += (int)matrix_DG[j, i].Value;
                    }
                }
            }
            textBox1.Text = d.ToString();
        }
    }
}
