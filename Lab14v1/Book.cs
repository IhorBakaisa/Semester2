using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class Book
    {

        public string Authors { get; set; }
        public string NameBook { get; set; }
        public string Publishing_house { get; set; }
        public string Library_section { get; set; }
        public string Origin_book { get; set; }
        public string Availability { get; set; }
    
        public Book(string Authors, string NameBook, string Publishing_house, string Library_section, string Origin_book, string Availability)
        {
            this.Authors = Authors;
            this.NameBook = NameBook;
            this.Publishing_house = Publishing_house;
            this.Library_section = Library_section;
            this.Origin_book = Origin_book;
            this.Availability = Availability;
        }
    }
}
