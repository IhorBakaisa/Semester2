using System;

namespace Lab4z5v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кiлькiсть стовпцiв = ");
            int m = Convert.ToInt32(Console.ReadLine());
            int maxValue = 10;
            int minValue = -10;

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
            int p = 0;
            for (int i = 0; i < n; i++)
            {
                int c = i + 1;
                for (int j = 0; j < m; j++)
                {
                    int z = j + 1;
                    if (matrix[i][j] == 0)
                    {
                        p += 1;
                        break;
                    }
                }
            }
            int y = n - p;

            
            // Виведення результату.
            Console.WriteLine("Кiлькiсть рядкiв, якi не мiстять жодного нульового елемента = {0}", y);
        }
    }
}
