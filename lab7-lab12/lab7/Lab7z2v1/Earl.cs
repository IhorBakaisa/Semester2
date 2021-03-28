using System;
using System.Collections.Generic;
using System.Text;

namespace Lab7z2v1
{
    class DisorientedEarl
    {
        public int number_top;

        DisorientedEarl()
        {
            this.number_top = 0;
        }

        public DisorientedEarl(int number_top)
        {
            this.number_top = number_top;
        }

        public DisorientedEarl(DisorientedEarl disorientedEarl)
        {
            this.number_top = disorientedEarl.number_top;
        }

        public string number_Top()
        {
            return $"Кiлькiсть вершин = {this.number_top}";
        }

        public string numbers_ribs_Earl()
        {
            return $"Кількість ребер графа = {this.number_top}";
        }

        public string add_rib_Earl()
        {
            return $"Кількість ребер графа = {this.number_top+1}";
        }

        public string str()
        {
            return $"Number_top: {this.number_top};";
        }

        public string remove_rib_Earl()
        {
            return $"Кількість ребер графа = {this.number_top-1}";
        }

    }
}
