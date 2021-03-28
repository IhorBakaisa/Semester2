using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12z1v1
{
    class Quadrangle1
    {
        public double A;
        public double B;
        public double C;
        public double D;

        public Quadrangle1(double a, double b, double c, double d)
        {
            A = a;
            B = b;
            C = c;
            D = d;
        }

        public double S()
        {
            return A * B;
        }

        public double P()
        {
            return A+B+C+D;
        }
    }
}
