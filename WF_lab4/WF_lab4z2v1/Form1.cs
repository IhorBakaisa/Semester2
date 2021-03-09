using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab4z2v1
{
    public partial class WF_lab4z2v1 : Form
    {
        //1*2*3*...*n
        static long Multiplication(int n)
        {
            long d = 1;
            for (int i = 1; i <= n; i++)
                d *= i;
            return d;

        }
        //1+2+3+...+n
        static long Sum(int n)
        {
            long s = 0;
            for (int i = 1; i <= n; i++)
                s += i;
            return s;
        }
  
        public WF_lab4z2v1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = (int)rowCount.Value;
            int m = (int)colCount.Value;

            double[][] result = new double[n][]; 
            for (int i = 0; i < n; i++)
            {
                int c = i + 1;
                result[i] = new double[m]; 
                for (int j = 0; j < m; j++)
                {
                    int z = j + 1;
                    if ((c * z) % 2 == 0)
                        result[i][j] = Multiplication(z);
                    else
                        result[i][j] = Sum(c);
                }
            }

            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1[j, 0].Value = result[i];
                }
            }
        }

        private void WF_lab4z2v1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 1;
            dataGridView1.ColumnCount = 1;
        }

        private void colCount_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = (int)colCount.Value;
        }
    }
}
