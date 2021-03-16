using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab4z4v1
{
    public partial class WF_lab4z4v1 : Form
    {
        public WF_lab4z4v1()
        {
            InitializeComponent();
        }

        private void WF_lab4z4v1_Load(object sender, EventArgs e)
        {
            matrix.RowCount = (int)rowcolNumber.Value;
            matrix.ColumnCount = (int)rowcolNumber.Value;
        }

        private void rowcolNumber_ValueChanged(object sender, EventArgs e)
        {
            matrix.RowCount = (int)rowcolNumber.Value;
            matrix.ColumnCount = (int)rowcolNumber.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < matrix.RowCount; i++)
            {
                for (int j = 0; j < matrix.ColumnCount; j++)
                {
                    matrix[j, i].Value = rand.Next(-100, 100);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32((int)rowcolNumber.Value);

            double[][] res = new double[n][];
            for (int i = 0; i < n; i++)
            {
                res[i] = new double[n];
                for (int j = 0; j < n; j++)
                {
                    res[i][j] = Convert.ToDouble(matrix[j, i].Value);
                }
            }

            // Розміщення парних рядків матриці за зростанням.
            for (int i = 0; i < n; i++)
            {
                int c = i + 1;
                for (int j = 0; j < n; j++)
                {
                    int z = j + 1;
                    if (c % 2 == 0)
                    {
                        Array.Sort(res[i]);
                    }
                }
            }

            // Виведення матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix.Rows[i].Cells[j].Value = res[i][j];
                }
            }
        }
    }
}
