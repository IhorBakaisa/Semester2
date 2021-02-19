using System;

namespace Lab1z2v1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b = ");
            b = Convert.ToDouble(Console.ReadLine());

            if (1<=a && a<=2 && 1<=b && b<=2 || 3<a && a<7 && 3<b && b<7)
            {
                Console.WriteLine("Належать");
            }
            else
            {
                Console.WriteLine("Неналежать");
            }
        }
    }
}
