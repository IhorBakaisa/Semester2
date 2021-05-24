using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class KasaDatabase
    {
        private List<Kasa> _Db = new List<Kasa>();

        //додати
        public void Add(Kasa kasa)
        {
            _Db.Add(kasa);
        }

        //вилучити
        public void Remove(Kasa kasa)
        {
            _Db.Remove(kasa);
        }

        //дізнатись кількість записів в базі
        public int Count
        {
            get
            {
                return _Db.Count;
            }
        }

        public List<Kasa> Query(Func<Kasa, bool> condition)
        {
            return _Db.Where(condition).ToList();
        }

        public List<Kasa> GetAll()
        {
            return this._Db;
        }

        public Kasa GetByIndex(int index)
        {
            return this._Db[index];
        }

    }
}
