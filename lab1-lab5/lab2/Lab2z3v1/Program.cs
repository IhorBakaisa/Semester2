using System;

namespace Lab2z3v1
{
    class Program
    {
        static void Main(string[] args)
        {
            double eps, x, a, n, s, b, k;

            Console.WriteLine("Епсилон = ");
            eps = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x = ");
            x = Convert.ToDouble(Console.ReadLine());

            a = Math.Log(x);
            s = 2;
            if (x > 0)
            {
                n = 1;
                b = 1 / (2 * n - 1) * (Math.Pow(x - 1 / x + 1, 2 * n - 1));
                while ( Math.Abs(b) > eps)
                {
                    k = 1 / (2 * n - 1);
                    b = k * (Math.Pow(x - 1 / x + 1, 2 * n - 1));
                    s += b;
                    n += 1;
                }
    
            }
            else
            {
                Console.WriteLine("Error");
            }

            if (a == s)
            {
                Console.WriteLine("Рівність справедлива");
            }
            else
            {
                Console.WriteLine("Рівність несправедлива");
            }
        }
    }
}
