using System;

namespace Lab5z2v1
{
    class Program
    {
        static double Skal(double[] x, double[] y, int n)
        {
            double d = 0;
            for (int i = 0; i<n; i++)
            {
                d += x[i] * y[i];
            }
            return d;
        }
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());

            double[] a = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            double[] b = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("b[{0}] = ", i + 1);
                b[i] = int.Parse(Console.ReadLine());
            }
            double[] c = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("c[{0}] = ", i + 1);
                c[i] = int.Parse(Console.ReadLine());
            }

            double z1 = Skal(a, b, n);
            double z2 = Skal(a, c, n);
            double s = (2 * z1) - (3*z2);
            Console.WriteLine("Результат виразу s = {0}", s);
        }
    }
}
