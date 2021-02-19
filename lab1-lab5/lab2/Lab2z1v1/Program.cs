using System;

namespace Lab2z1v1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, m, k;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            m = 1;

            for (int i = 0; n>i; i++)
            {
                k = a + i;
                m *= k;
            }

            Console.WriteLine("Добуток = {0}", m);
        }
    }
}
