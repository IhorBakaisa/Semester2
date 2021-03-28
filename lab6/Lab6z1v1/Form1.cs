using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6z1v1
{
    public partial class Lab6z1v1 : Form
    {
        struct Person
        {
            public string passport_data;
            public string education;
            public string specialty;
            public string position;
            public int salary;

            public string DisplayInfo()
            {
                return $"Passport_data: {passport_data}  Education: {education}  Specialty: {specialty}  Position: {position}  Salary: {salary};";
            }
        }
        public Lab6z1v1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person p1;
            p1.passport_data = textBox1.Text;
            p1.education = textBox2.Text;
            p1.specialty = textBox3.Text;
            p1.position = textBox4.Text;
            p1.salary = Convert.ToInt32(textBox5.Text);
            textBox11.Text = p1.DisplayInfo();

            Person p2;
            p2.passport_data = textBox6.Text;
            p2.education = textBox7.Text;
            p2.specialty = textBox8.Text;
            p2.position = textBox9.Text;
            p2.salary = Convert.ToInt32(textBox10.Text);
            textBox12.Text = p2.DisplayInfo();
        }
    }
}
