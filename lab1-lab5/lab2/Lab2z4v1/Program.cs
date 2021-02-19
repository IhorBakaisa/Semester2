using System;

namespace Lab2z4v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            double f, ff;

            n = 10;
            f = 1;
            ff = 0;
            for (i = 1; i <= n; i++)
            {
                ff = f + (2 * i);
                f = ff;
            }

            Console.WriteLine("Результат = {0}", ff);
        }
    }
}
