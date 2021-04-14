using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vectors
{
    public class Vector
    {
        public int X { get; }
        public int Y { get; }
        public int Z { get; }
        public Vector (int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2) + Math.Pow(Z, 2));
        }

        public double DotProduct(Vector other)
        {
            double result = 0;
            result = this.X*other.X + this.Y*other.Y + this.Z*other.Z;
            return result;
        }

        public Vector VectorProduct(Vector other)
        {
            int x, y, z;

            x = this.Y * other.Z - this.Z * other.Y;
            y = this.Z * other.X - this.X * other.Z;
            z = this.X * other.Y - this.Y * other.X;

            return new Vector(x, y, z);
        }

        public double Cosine(Vector other)
        {
            double LengthProduct = (this.Length() * other.Length());
            if (LengthProduct ==0)
            {
                Console.WriteLine("One of your vectors is Null-Vector.");
                return 0;
            }
            return DotProduct(other) / LengthProduct;
        }

        public Vector Sum(Vector other)
        {
            int x, y, z;

            x = this.X + other.X;
            y = this.Y + other.Y;
            z = this.Z + other.Z;

            return new Vector(x, y, z);
        }

        public Vector Difference(Vector other)
        {
            int x, y, z;

            x = this.X - other.X;
            y = this.Y - other.Y;
            z = this.Z - other.Z;

            return new Vector(x, y, z);
        }

        public string CoordsText()
        {
            return $"({this.X}, {this.Y}, {this.Z})";
        }

    }
}
