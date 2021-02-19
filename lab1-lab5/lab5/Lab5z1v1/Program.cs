using System;

namespace Lab5z1v1
{
    class Program
    {
        static double f(double x, double y)
        {
            if (x > y)
            {
                return Math.Pow(x, 3) + Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 4));
            }
            else
            {
                return (Math.Pow(x, 2)-(2*x)+Math.Sqrt(x)) / (Math.Pow(x, 3)/5.0);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            double u = f(a, b) + f(2, a) + 2;
            Console.WriteLine("u = {0}", u);
        }
    }
}
