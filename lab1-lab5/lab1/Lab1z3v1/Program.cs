using System;

namespace Lab1z3v1
{
    class Program
    {
        static double side(double x, double y, double z, double f)
        {
            return Math.Sqrt(Math.Pow(x - y, 2) + Math.Pow(z - f, 2));
        }
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3;
            Console.Write("x1 = ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y1 = ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x2 = ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y2 = ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("x3 = ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("y3 = ");
            y3 = Convert.ToDouble(Console.ReadLine());

            double a, b, c, p;
            a = side(x2, x1, y2, y1);
            b = side(x3, x2, y3, y2);
            c = side(x1, x3, y1, y3);

            if (a+b>c || a+c>b || b+c>a)
            {
                Console.WriteLine("Трикутник вироджений");
            }
            else
            {
                Console.WriteLine("Трикутник не вироджений");
            }
        }
    }
}
