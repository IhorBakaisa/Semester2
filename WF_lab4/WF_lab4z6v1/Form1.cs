using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab4z6v1
{
    public partial class WF_lab4z6v1 : Form
    {
        public WF_lab4z6v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int maxValue = 100;
            int minValue = -100;

            // Генерування рандомної матриці n x m.
            double[][] matrix = new double[n][];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[m];
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = Convert.ToInt32(rnd.NextDouble() * (maxValue - minValue) + minValue);
                }
            }

            int d = 0;
            while (d < 1)
            {
                double maxElement = matrix[0][0];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i][j] > maxElement)
                        {
                            maxElement = matrix[i][j];
                        }
                    }
                }

                double minElement = matrix[0][0];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i][j] < maxElement)
                        {
                            minElement = matrix[i][j];
                        }
                    }
                }

                int b = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i][j] == maxElement)
                        {
                            b += 1;
                        }
                    }
                }
                if (b >= 2)
                {
                    d += 1;
                    textBox3.Text = maxElement.ToString();
                }
                else if (b == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (matrix[i][j] == maxElement)
                            {
                                minElement = matrix[i][j];
                            }
                        }
                    }
                }
            }
        }
    }
}
