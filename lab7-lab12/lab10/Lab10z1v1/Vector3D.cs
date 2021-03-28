using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10z1v1
{
    class Vector3D : Vector2D
    {
        public int z { get; }

        public Vector3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
        }

        public new string vector_length()
        {
            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z,2));
            return $"Довжина вектора = {d}";
        }

        public new string normalization_vector()
        {
            double d = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double dz = z / d;
            return $"{base.normalization_vector()}+{dz}";
        }

        public new string str()
        {
            return $"({base.str()};{z})";
        }

        public string comparison(Vector3D otherVector3D)
        {
            return $"Порівняння = ({base.comparison(otherVector3D)};{z - otherVector3D.z})";
        }

        public string dod(Vector3D otherVector3D)
        {
            return $"({base.dod(otherVector3D)};{z + otherVector3D.z})";
        }

        public string vid(Vector3D otherVector3D)
        {
            return $"({base.vid(otherVector3D)};{z - otherVector3D.z})";
        }

        public int skall(Vector3D otherVector3D)
        {
            return base.skall(otherVector3D) + (z * otherVector3D.z);
        }
    }
}
