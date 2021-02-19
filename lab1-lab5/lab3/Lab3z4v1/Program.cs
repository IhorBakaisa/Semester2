using System;

namespace Lab3z4v1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Кiлькiсть елементiв = ");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] Arr = new double[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Arr[{0}] = ", i + 1);
                Arr[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(Arr);
            for (int i = 0; i<n; i++)
            {
                Console.Write("A[{0}] = {1}; ",i+1 , Arr[i]);
            }
        }  
    }
}
