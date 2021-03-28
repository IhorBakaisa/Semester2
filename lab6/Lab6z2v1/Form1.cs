using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6z2v1
{
    struct Detals
    {
        public string name_spare_parts;
        public string car_brand;
        public int graduation_year;

        public string DisplayInfo()
        {
            return $"Name_spare_parts: {name_spare_parts},  Car_brand: {car_brand},  Graduation_year: {graduation_year};";
        }
    }
    public partial class Lab6z2v1 : Form
    {
        public Lab6z2v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Detals detal1;
            detal1.name_spare_parts = textBox1.Text;
            detal1.car_brand = textBox2.Text;
            detal1.graduation_year = Convert.ToInt32(textBox3.Text);
            textBox4.Text = detal1.DisplayInfo();

            Detals detal2;
            detal2.name_spare_parts = textBox5.Text;
            detal2.car_brand = textBox6.Text;
            detal2.graduation_year = Convert.ToInt32(textBox7.Text);
            textBox8.Text = detal2.DisplayInfo();
        }
    }
}
