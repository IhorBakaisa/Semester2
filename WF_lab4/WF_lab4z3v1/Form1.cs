using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WF_lab4z3v1
{
    public partial class WF_lab4z3v1 : Form
    {
        public WF_lab4z3v1()
        {
            InitializeComponent();
        }

        private void WF_lab4z3v1_Load(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 2;
            dataGridView1.ColumnCount = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(dataGridView1[0, 0].Value);
            double b = Convert.ToDouble(dataGridView1[1, 1].Value);
            double c = Convert.ToDouble(dataGridView1[1, 0].Value);
            double d = Convert.ToDouble(dataGridView1[0, 1].Value);
            double det = (a * b) - (c * d);
            textBox1.Text = det.ToString();
        }
    }
}
