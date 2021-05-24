using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBSimulation
{
    class Kasa
    {
        public int numberKasa { get; set; }
        public int numberOperation { get; set; }
        public int moneySum { get; set; }
        public int typeOperation { get; set; }




        public Kasa(int numberKasa, int numberOperation, int moneySum, int typeOperation)
        {
            this.numberKasa = numberKasa;
            this.numberOperation = numberOperation;
            this.moneySum = moneySum;
            this.typeOperation = typeOperation;
        }
    }
}
