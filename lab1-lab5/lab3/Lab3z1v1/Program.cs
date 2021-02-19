using System;

namespace Lab3z1v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] x = new double[n];
            for (int i = 0; i<n; i++)
            {
                Console.Write("x[{0}] =",i+1);
                x[i] = int.Parse(Console.ReadLine());
            }
            double s = 0;
            for (int i = 0; i<n; i++)
            {
                s += x[i];
            }
            s = s / n;
            Console.WriteLine("Середнє арифметичне = {0}", s);
        }   
    }
}
