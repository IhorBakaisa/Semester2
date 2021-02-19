using System;

namespace Lab3z2v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть елементiв у масивi A: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("x = ");
            double x = Convert.ToInt32(Console.ReadLine());
            Console.Write("y =  ");
            double y = Convert.ToInt32(Console.ReadLine());
            Console.Write("z =  ");
            double z = Convert.ToInt32(Console.ReadLine());

            double[] A = new double[n];

            A[0] = x;
            A[1] = x;
            A[2] = y;
            
            for (int i = 3; i < n; i++)
                {
                    A[i] = A[i - 2] + (A[i - 1] / Math.Pow(2, i-1) * A[i-3]);
                }
            int k = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > z)
                {
                    k += 1;
                }
            }

            Console.WriteLine("Кiлькiсть елементiв масиву A, якi бiльшi за z = {0}", k);
        }   
    }
}
