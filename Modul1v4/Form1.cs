using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modul1v4
{
    public partial class Modul1v4 : Form
    {
        public Modul1v4()
        {
            InitializeComponent();
        }

        private void Modul1v4_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)rowcolNumber.Value;
            dataGridView1.ColumnCount = (int)rowcolNumber.Value;
        }

        private void rowcolNumber_ValueChanged(object sender, EventArgs e)
        {
            dataGridView1.RowCount = (int)rowcolNumber.Value;
            dataGridView1.ColumnCount = (int)rowcolNumber.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int rowcol = (int)rowcolNumber.Value;
            Random rand = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = rand.Next(-100, 100);
                }
            }

            double[,] a = new double[rowcol, rowcol]; 
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    a[i, j] = (double)dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            SMatrix matrix1 = new SMatrix(a, rowcol);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix1.str(i , j);
                }
            }
            textBox1.Text = matrix1.strn();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int rowcol = (int)rowcolNumber.Value;
            double[,] a = new double[rowcol, rowcol];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    a[i, j] = (double)dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            SMatrix matrix1 = new SMatrix(a, rowcol);
            textBox1.Text = matrix1.maxElement();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowcol = (int)rowcolNumber.Value;
            double[,] a = new double[rowcol, rowcol];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    a[i, j] = (double)dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            SMatrix matrix1 = new SMatrix(a, rowcol);
            textBox1.Text = matrix1.minElement();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int rowcol = (int)rowcolNumber.Value;
            double[,] a = new double[rowcol, rowcol];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    a[i, j] = (double)dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            SMatrix matrix1 = new SMatrix(a, rowcol);
            textBox1.Text = matrix1.sumElement();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int rowcol = (int)rowcolNumber.Value;
            double[,] a = new double[rowcol, rowcol];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    a[i, j] = (double)dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            Random rand = new Random(DateTime.Now.Millisecond);
            double[,] b = new double[rowcol, rowcol];
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    b[i, j] = rand.Next(-100, 100);
                }
            }

            SMatrix matrix1 = new SMatrix(a, rowcol);
            SMatrix matrix2 = new SMatrix(b, rowcol);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix1 + matrix2;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int rowcol = (int)rowcolNumber.Value;
            double[,] a = new double[rowcol, rowcol];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    a[i, j] = (double)dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            Random rand = new Random(DateTime.Now.Millisecond);
            double[,] b = new double[rowcol, rowcol];
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    b[i, j] = rand.Next(-100, 100);
                }
            }

            SMatrix matrix1 = new SMatrix(a, rowcol);
            SMatrix matrix2 = new SMatrix(b, rowcol);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix1 - matrix2;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int rowcol = (int)rowcolNumber.Value;
            double[,] a = new double[rowcol, rowcol];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    a[i, j] = (double)dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            Random rand = new Random(DateTime.Now.Millisecond);
            double[,] b = new double[rowcol, rowcol];
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    b[i, j] = rand.Next(-100, 100);
                }
            }

            SMatrix matrix1 = new SMatrix(a, rowcol);
            double k = Convert.ToDouble(textBox2.Text);
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView1.Rows[i].Cells[j].Value = matrix1 * k;
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int rowcol = (int)rowcolNumber.Value;
            double[,] a = new double[rowcol, rowcol];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    a[i, j] = (double)dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            double a_ = Convert.ToDouble(textBox3.Text);
            double b_ = Convert.ToDouble(textBox4.Text);

            int d = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a_ <= a[i, j] && a[i, j] <= b_)
                        d += 1;
                }
            }
            textBox1.Text = $"Кількість елементів які вxодять у відрізок [{a_},{b_}] = {d}";
        }
    }
}
