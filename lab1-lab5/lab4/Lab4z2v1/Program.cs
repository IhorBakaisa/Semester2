using System;

namespace Lab4z2v1
{
    class Program
    {
        //1*2*3*...*n
        static long Multiplication(int n)
        {
            long d = 1;
            for (int i = 1; i <= n; i++)
                d *= i;
            return d;

        }
        //1+2+3+...+n
        static long Sum(int n)
        {
            long s = 0;
            for (int i = 1; i <= n; i++)
                s += i;
            return s;
        }

        //Побудувати матрицю А, елементи якої задаються формулою:
        static double[][] GenerateMatrixByFormula(int RowCount, int ColCount)
        {
            //[[1,2],[3,4]]
            double[][] result = new double[RowCount][]; // result = [[],[]]
            for (int i = 0; i < RowCount; i++)
            {
                int c = i + 1;
                result[i] = new double[ColCount]; //result=[[0,0],[]]
                for (int j = 0; j < ColCount; j++)
                {
                    int z = j + 1;
                    if ((c * z) % 2 == 0)
                        //парне
                        result[i][j] = Multiplication(z);
                    else
                        //непарне
                        result[i][j] = Sum(c);
                }
            }

            return result;
        }

        static void PrintMatrix(double[][] matrix, int rowCount, int colCount)
        {
            for (int i = 0; i < rowCount; i++)
            {
                Console.Write("[");
                for (int j = 0; j < colCount; j++)
                    Console.Write("{0},", matrix[i][j]);
                Console.Write("]");
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть рядкiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Кiлькiсть стовпцiв = ");
            int m = Convert.ToInt32(Console.ReadLine());
            PrintMatrix(GenerateMatrixByFormula(n, m), n, m);

        }
    }
}