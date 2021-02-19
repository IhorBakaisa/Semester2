using System;

namespace Lab4z6v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кiлькiсть стовпцiв = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int maxValue = 100;
            int minValue = -100;

            // Генерування рандомної матриці n x m.
            double[][] matrix = new double[n][];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                matrix[i] = new double[m];
                for (int j = 0; j < m; j++)
                {
                    matrix[i][j] = Convert.ToInt32(rnd.NextDouble() * (maxValue - minValue) + minValue);
                }
            }

            // Виведення матриці.
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    Console.Write("{0}\t", matrix[i][j]);
                Console.WriteLine();
            }

            int d = 0;
            while (d < 1)
            {
                double maxElement = matrix[0][0];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i][j] > maxElement)
                        {
                            maxElement = matrix[i][j];
                        }
                    }
                }

                double minElement = matrix[0][0];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i][j] < maxElement)
                        {
                            minElement = matrix[i][j];
                        }
                    }
                }

                int b = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (matrix[i][j] == maxElement)
                        {
                            b += 1;
                        }
                    }
                }
                if (b >= 2)
                {
                    d += 1;
                    Console.WriteLine("Максимальне число яке зустрічається більше одного разу = {0}", maxElement);
                }
                else if (b == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        for (int j = 0; j < m; j++)
                        {
                            if (matrix[i][j] == maxElement)
                            {
                                minElement = matrix[i][j];
                            }
                        }
                    }
                }
            }
        }
    }
}