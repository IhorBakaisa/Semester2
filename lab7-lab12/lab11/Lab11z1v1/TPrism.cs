using System;
using System.Collections.Generic;
using System.Text;

namespace Lab11z1v1
{
    class TPrism
    {
        public double height;
        public double perimeter;
        public double area_foundation;

        public virtual double area_full_prism()
        {
            return (perimeter * height) + (2 * area_foundation);
        }

        public virtual double volumePrism()
        {
            return area_foundation * height;
        }

        public virtual string str()
        {
            return $"Height: {height},  Perimeter: {perimeter},  Area_foundation: {area_foundation},  Area_full_prism: {area_full_prism()},  VolumePrism: {volumePrism()};";
        }
    }
}
