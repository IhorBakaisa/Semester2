using System;

namespace Lab4z4v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв та стовпцiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int maxValue = 100;
            int minValue = -100;

            // Генерування рандомної матриці n x n.
            double[][] matrix = new double[n][];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[n];
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = Convert.ToInt32(rnd.NextDouble() * (maxValue - minValue) + minValue);
                }
            }

            // Розміщення парних рядків матриці за зростанням.
            for (int i = 0; i < n; i++)
            {
                int c = i + 1;
                for (int j = 0; j < n; j++)
                {
                    int z = j + 1;
                    if (c % 2 == 0)
                    {
                        Array.Sort(matrix[i]);
                    }
                }
            }

            // Виведення матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }
        }
    }
}