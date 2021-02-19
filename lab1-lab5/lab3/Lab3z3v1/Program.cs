using System;

namespace Lab3z3v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] x = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("x[{0}] = ", i + 1);
                x[i] = int.Parse(Console.ReadLine());
            }

            double[] y = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("y[{0}] = ", i + 1);
                y[i] = int.Parse(Console.ReadLine());
            }

            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                c[i] = x[i] + y[i];
                Console.Write("c[{0}] = {1}; ", i+1, c[i]);
            }
        }
    }
}
