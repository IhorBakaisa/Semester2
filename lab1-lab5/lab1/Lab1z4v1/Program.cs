using System;

namespace Lab1z4v1
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, C, N, y;
            Console.Write("A = ");
            A = Convert.ToDouble(Console.ReadLine());
            Console.Write("C = ");
            C = Convert.ToDouble(Console.ReadLine());
            Console.Write("N = ");
            N = Convert.ToDouble(Console.ReadLine());

            if (A == C && C == N)
            {
                y = Math.Cos(A + C + N);
            }
            else if (A < C && C == N)
            {
                y = Math.Cos(A * C * N);
            }
            else if (A < C && C < N)
            {
                y = Math.Cos((A + C) * N);
            }
            else
            {
                y = 0.0;
            }

            Console.WriteLine("y = {0}", y);
        }
    }
}
