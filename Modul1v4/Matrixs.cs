using System;
using System.Collections.Generic;
using System.Text;

namespace Modul1v4
{
    class SMatrix
    {
        public double[,] matrix;
        public int n;

        SMatrix()
        {
            this.n = 0;
        }

        public SMatrix(double[,] Matrix, int N)
        {
            this.matrix = Matrix;
            this.n = N;
        }

        public SMatrix(SMatrix matrix)
        {
            this.matrix = matrix.matrix;
            this.n = matrix.n;
        } 

        public string maxElement()
        {
            double MaxElement = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i, j] > MaxElement)
                    {
                        MaxElement = matrix[i, j];
                    }
                }
            }
            return $"Максимальний елемент = {MaxElement}";
        }

        public string sumElement()
        {
            double SumElement = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    SumElement += matrix[i, j];
                }
            }
            return $"Сума елементів матриці = {SumElement}";
        }

        public string minElement()
        {
            double MinElement = 999999;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix.Length; j++)
                {
                    if (matrix[i, j] < MinElement)
                    {
                        MinElement = matrix[i, j];
                    }
                }
            }
            return $"Мінімальнийльний елемент = {MinElement}";
        }

        public static double[,] operator +(SMatrix mat1, SMatrix mat2)
        {
            double[,] mat = new double[mat1.n, mat1.n];
            for (int i = 0; i < mat1.n; i++)
            {
                for (int j = 0; j < mat1.n; j++)
                {
                    mat[i, j] = mat1.matrix[i, j] + mat2.matrix[i, j];
                }
            }
            return mat;
        }

        public static double[,] operator -(SMatrix mat1, SMatrix mat2)
        {
            double[,] mat = new double[mat1.n, mat1.n];
            for (int i = 0; i < mat1.n; i++)
            {
                for (int j = 0; j < mat1.n; j++)
                {
                    mat[i, j] = mat1.matrix[i, j] - mat2.matrix[i, j];
                }
            }
            return mat;
        }

        public static double[,] operator *(SMatrix mat1, double mat2)
        {
            double[,] mat = new double[mat1.n, mat1.n];
            for (int i = 0; i < mat1.n; i++)
            {
                for (int j = 0; j < mat1.n; j++)
                {
                    mat[i, j] = mat1.matrix[i, j] * mat2;
                }
            }
            return mat;
        }

        public string strn()
        {
            return $"{n}X{n}";
        }

        public double str(int i ,int j)
        {
            return matrix[i, j];
        }
    }
}
