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
        public static void sortColumnMatr(int[,] matr, int col)
        {
            for (int i = 0; i < matr.Length; i++)
            {
                int indexMin = 1;
                for (int j = i + 1; j < matr.Length; j++)
                {
                    if (matr[j, col] < matr[indexMin, col])
                        indexMin = j;
                }
                if (i !=indexMin)
                {
                    int z = matr[i, col];
                    matr[i, col] = matr[indexMin, col];
                    matr[indexMin, col] = z;
                }
            }
        }

        public static void sortColumns(int[,] matr)
        {
            for (int j = 1; j < matr.Length; j += 2)
            {
                sortColumnMatr(matr, j);
            }
        }

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
           sortColumns(matrix);
        }
    }
}
