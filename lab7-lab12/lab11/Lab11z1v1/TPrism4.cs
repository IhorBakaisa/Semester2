using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11z1v1
{
    class TPrism4 : TPrism
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public double D { get; set; }
        public double H { get; set; }

        public TPrism4(double a, double b, double c, double d, double h)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            H = h;
        }

        public double area_osn()
        {
            return A * B;
        }

        public override double area_full_prism()
        {
            return ((A + B + C + D) * H) + (2 * area_osn());
        }

        public override double volumePrism()
        {
            return area_osn() * H;
        }

        public override string str()
        {
            return $"A: {A},  B: {B},  C: {C},  H: {H}  ,  Area_osn: {area_osn()},  Area_full_prism: {area_full_prism()},  VolumePrism: {volumePrism()};";
        }
    }
}
