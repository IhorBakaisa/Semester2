using System;
using System.Collections.Generic;
using System.Text;

namespace Lab10z1v1
{
    class Vector2D
    {
        public int x { get; }
        public int y { get; }

        Vector2D()
        {
            this.x = 0;
            this.y = 0;
        }

        public Vector2D(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector2D(Vector2D vector2D)
        {
            this.x = vector2D.x;
            this.y = vector2D.y;
        }

        public string vector_length()
        {
            double d = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            return $"Довжина вектора = {d}";
        }

        public string normalization_vector()
        {
            double d = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
            double dx = this.x / d;
            double dy = this.y / d;
            return $"{dx}+{dy}";
        }

        public string str()
        {
            return $"{this.x};{this.y}";
        }

        public string comparison(Vector2D otherVector2D)
        {
            return $"{this.x - otherVector2D.x};{this.y - otherVector2D.y}";
        }

        public string dod(Vector2D otherVector2D)
        {
            return $"{this.x + otherVector2D.x};{this.y + otherVector2D.y}";
        }

        public string vid(Vector2D otherVector2D)
        {
            return $"{this.x - otherVector2D.x};{this.y - otherVector2D.y}";
        }

        public int skall(Vector2D otherVector2D)
        {
            return (this.x * otherVector2D.x) + (this.y * otherVector2D.y);
        }
    }
}
