using System;

namespace Lab2z2v1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            Console.Write("n = ");
            n = Convert.ToInt32(Console.ReadLine());

            i = 0;

            if (n == 0)
            {
                i += 1;
            }
            else if (n > 0)
            {
                while (n > 0)
                {
                    n = n / 10;
                    i += 1;
                }
            }
            else
            {
                if (n == -1)
                {
                    i += 1;
                }
                else
                {
                    while (n < -1)
                    {
                        n = n / 10;
                        i += 1;
                    }
                }
            }

            Console.WriteLine("Кількість цифр = {0}", i);
        }
    }
}
