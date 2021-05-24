using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace DBSimulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FillTestData();
            Show(_db.GetAll());
        }

        private KasaDatabase _db = new KasaDatabase();
        private void FillTestData()
        {
            _db.Add(new Kasa(
                1,
                67,
                2000,
                1
                ));
            _db.Add(new Kasa(
               2,
                671,
                5000,
                0
               ));
            _db.Add(new Kasa(
               3,
                20,
                200000,
                1
             ));
        }

        private void Show(List<Kasa> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Нема що виводити");
                return;
            }
            dataGridView1.RowCount = list.Count;
            for (int i=0;i<list.Count;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = list[i].numberKasa;
                dataGridView1.Rows[i].Cells[1].Value = list[i].numberOperation;
                dataGridView1.Rows[i].Cells[2].Value = list[i].moneySum;
                dataGridView1.Rows[i].Cells[3].Value = list[i].typeOperation;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Show(_db.GetAll());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            Kasa KasaToDelete = _db.GetByIndex(i);
            _db.Remove(KasaToDelete);
            Show(_db.GetAll());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kasa newKasa = new Kasa(
                Convert.ToInt32(textBoxnumberKasa.Text),
                Convert.ToInt32(textBoxnumberOperation.Text),
                Convert.ToInt32(textBoxmoneySum.Text),
                Convert.ToInt32(textBoxtypeOperation.Text)
                );
            _db.Add(newKasa);
            Show(_db.GetAll());
            tabControl1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("text.txt", true);
            sw.WriteLine(textBoxnumberKasa.Text);
            sw.WriteLine(textBoxnumberOperation.Text);
            sw.WriteLine(textBoxmoneySum.Text);
            sw.WriteLine(textBoxtypeOperation.Text);
            sw.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StreamReader sw = new StreamReader("text.txt");
          
            Kasa newKasa = new Kasa(
                 Convert.ToInt32(sw.ReadLine()),
                 Convert.ToInt32(sw.ReadLine()),
                 Convert.ToInt32(sw.ReadLine()),
                 Convert.ToInt32(sw.ReadLine())
                );

            sw.Close();
            _db.Add(newKasa);
            Show(_db.GetAll());
            tabControl1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox1.Text);
            Show(_db.Query(kasa => kasa.moneySum > a));
            tabControl1.SelectedIndex = 0;
        }
    }
}
