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
            Show(_db.GetAll());
        }

        private BookDatabase _db = new BookDatabase();
       

        private void Show(List<Book> list)
        {
            if (list.Count == 0)
            {
                MessageBox.Show("Нема що виводити");
                return;
            }
            dataGridView1.RowCount = list.Count;
            for (int i=0;i<list.Count;i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = list[i].Authors;
                dataGridView1.Rows[i].Cells[1].Value = list[i].NameBook;
                dataGridView1.Rows[i].Cells[2].Value = list[i].Publishing_house;
                dataGridView1.Rows[i].Cells[3].Value = list[i].Library_section;
                dataGridView1.Rows[i].Cells[4].Value = list[i].Origin_book;
                dataGridView1.Rows[i].Cells[5].Value = list[i].Availability;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Show(_db.GetAll());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string arbitrary_request = textBoxAuthors.Text;
            Show(_db.Query(book => book.Authors.ToUpper().Contains(arbitrary_request.ToUpper())));
            tabControl1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string namebook = textBoxNameBook.Text;
            Show(_db.Query(book => book.NameBook.ToUpper().Contains(namebook.ToUpper())));
            tabControl1.SelectedIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string publishing_house = textBoxPublishing_house.Text;
            Show(_db.Query(book => book.Publishing_house.ToUpper().Contains(publishing_house.ToUpper())));
            tabControl1.SelectedIndex = 0;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string library_section = textBoxLibrary_section.Text;
            Show(_db.Query(book => book.Library_section.ToUpper().Contains(library_section.ToUpper())));
            tabControl1.SelectedIndex = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string origin_book = textBoxOrigin_book.Text;
            Show(_db.Query(book => book.Origin_book.ToUpper().Contains(origin_book.ToUpper())));
            tabControl1.SelectedIndex = 0;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string availability = textBoxAvailability.Text;
            Show(_db.Query(book => book.Availability.ToUpper().Contains(availability.ToUpper())));
            tabControl1.SelectedIndex = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Book newBook = new Book(
                textBoxAuthors.Text,
                textBoxNameBook.Text,
                textBoxPublishing_house.Text,
                textBoxLibrary_section.Text,
                textBoxOrigin_book.Text,
                textBoxAvailability.Text
                );
            _db.Add(newBook);
            Show(_db.GetAll());
            tabControl1.SelectedIndex = 0;
            StreamWriter sw = new StreamWriter("text.txt", true);
            sw.WriteLine(textBoxAuthors.Text);
            sw.WriteLine(textBoxNameBook.Text);
            sw.WriteLine(textBoxPublishing_house.Text);
            sw.WriteLine(textBoxLibrary_section.Text);
            sw.WriteLine(textBoxOrigin_book.Text);
            sw.WriteLine(textBoxAvailability.Text);
            sw.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentCell.RowIndex;
            Book BookToDelete = _db.GetByIndex(i);
            _db.Remove(BookToDelete);
            Show(_db.GetAll());
        }
    }
}
