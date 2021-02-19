using System;

namespace Lab4z3v1
{
    class Program
    {
        static double IntroductionMatrix(int RowCount, int ColCount)
        {
            double[][] result = new double[RowCount][];
            for (int i = 0; i < RowCount; i++)
            {
                result[i] = new double[ColCount]; 
                for (int j = 0; j < ColCount; j++)
                {
                    Console.Write("Matrix[{0}][{1}] = ", i+1, j+1);
                    result[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            double det = (result[0][0] * result[1][1]) - (result[0][1] * result[1][0]);
            return det;
        }
        static void Main(string[] args)
        {
            int n = 2;
            int m = 2;
            Console.WriteLine("Детермiнант = {0}", IntroductionMatrix(n, m));

        }
    }
}