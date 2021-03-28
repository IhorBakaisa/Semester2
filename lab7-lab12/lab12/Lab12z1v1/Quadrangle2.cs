using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12z1v1
{
    class Quadrangle2
    {
        public double x1;
        public double y1;
        public double x2;
        public double y2;
        public double x3;
        public double y3;
        public double x4;
        public double y4;

        public Quadrangle2(double X1, double Y1, double X2, double Y2, double X3, double Y3, double X4, double Y4)
        {

            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
            x3 = X3;
            y3 = Y3;
            x4 = X4;
            y4 = Y4;
        }

        public double A()
        {
            return Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
        }
        public double B()
        {
            return Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
        }
        public double C()
        {
            return Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));
        }
        public double D()
        {
            return Math.Sqrt(Math.Pow(x4, 2) + Math.Pow(y4, 2));
        }

        public double S()
        {
            return A() * B();
        }

        public double P()
        {
            return A() + B() + C() + D();
        }
    }
}
