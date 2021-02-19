using System;

namespace Lab4z1v1
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

            // Пошук та сума від'ємних елементів матриці з парними індексами.
            double d = 0;
            for (int i = 0; i < n; i++)
            {
                int c = i + 1;
                for (int j = 0; j < m; j++)
                {
                    int z = j + 1;
                    if (c%2 == 0 && z%2 == 0)
                    {
                        if (matrix[i][j] < 0)
                            d += matrix[i][j];
                    }
                }
            }

            // Виведення результату.
            Console.WriteLine("Сума вiд'ємних елементiв матрицi з обома парними iндексами = {0}", d);
        }
    }
}