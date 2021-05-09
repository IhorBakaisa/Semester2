using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class BookDatabase
    {
        private List<Book> _Db = new List<Book>();

        //додати
        public void Add(Book book)
        {
            _Db.Add(book);
        }

        //вилучити
        public void Remove(Book book)
        {
            _Db.Remove(book);
        }

        //дізнатись кількість записів в базі
        public int Count
        {
            get
            {
                return _Db.Count;
            }
        }

        public List<Book> Query(Func<Book, bool> condition)
        {
            return _Db.Where(condition).ToList();
        }

        public List<Book> GetAll()
        {
            return this._Db;
        }


    }
}
