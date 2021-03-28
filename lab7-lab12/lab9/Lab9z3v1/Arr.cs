using System;
using System.Collections.Generic;
using System.Text;

namespace Lab9z3v1
{
    class Array
    {
        private int[] a;

        public Array(params int[] a)
        {
            this.a = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                this.a[i] = a[i];
            }
        }

        public int maxElement()
        {
            int max = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            return max;
        }

        public int minElement()
        {
            int min = 999999;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            return min;
        }

        public string str()
        {
            string k = "";
            for (int i = 0; i < a.Length; i++)
            {
                k += $"{a[i]} ";
            }
            return k;
        }
    }
}
