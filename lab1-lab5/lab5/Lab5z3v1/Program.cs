using System;

namespace Lab5z3v1
{
    class Program
    {
        static int f(int i)
        {
            if (i == 1 || i == 2)
            {
                return 1;
            }
            else
            {
                return f(i - 1) + f(i - 2);
            }
        }
        static void Main(string[] args)
        {
            int s = f(3) + f(8);
            Console.WriteLine("Результат виразу s = {0}", s);
        }
    }
}
