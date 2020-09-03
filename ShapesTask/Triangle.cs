using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTask
{
    class Triangle : IShape
    {
        private readonly double X1;
        private readonly double Y1;
        private readonly double X2;
        private readonly double Y2;
        private readonly double X3;
        private readonly double Y3;

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            X3 = x3;
            Y3 = y3;
        }

        public double GetArea()
        {
            var lengthA = GetSideLength(X1, Y1, X2, Y2);
            var lengthB = GetSideLength(X2, Y2, X3, Y3);
            var lengthC = GetSideLength(X3, Y3, X1, Y1);
            var semiperimeter = (lengthA + lengthB + lengthC) / 2;

            return Math.Sqrt(semiperimeter * (semiperimeter - lengthA)
                                           * (semiperimeter - lengthB)
                                           * (semiperimeter - lengthC));
        }

        public double GetHeight()
        {
            return Math.Max(Y1, Math.Max(Y2, Y3)) - Math.Min(Y1, Math.Min(Y2, Y3));
        }

        public double GetPerimeter()
        {
            var lengthA = GetSideLength(X1, Y1, X2, Y2);
            var lengthB = GetSideLength(X2, Y2, X3, Y3);
            var lengthC = GetSideLength(X3, Y3, X1, Y1);

            return lengthA + lengthB + lengthC;
        }

        public double GetWidth()
        {
            return Math.Max(X1, Math.Max(X2, X3)) - Math.Min(X1, Math.Min(X2, X3));
        }

        private static double GetSideLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public override string ToString()
        {
            var lengthA = GetSideLength(X1, Y1, X2, Y2);
            var lengthB = GetSideLength(X2, Y2, X3, Y3);
            var lengthC = GetSideLength(X3, Y3, X1, Y1);
            return
                $"Треугольник. Площадь: {GetArea():0.####}, периметр: {GetPerimeter():0.####}, стороны: {lengthA:0.####}, {lengthB:0.####}, {lengthC:0.####}";
        }

        public override int GetHashCode()
        {
            var prime = 19;
            var hash = 1;

            hash = prime * hash + X1.GetHashCode();
            hash = prime * hash + X2.GetHashCode();
            hash = prime * hash + X3.GetHashCode();
            hash = prime * hash + Y1.GetHashCode();
            hash = prime * hash + Y2.GetHashCode();
            hash = prime * hash + Y3.GetHashCode();

            return hash;
        }

        public override bool Equals(object objectToCompare)
        {
            if (ReferenceEquals(objectToCompare, this))
            {
                return true;
            }

            if (ReferenceEquals(objectToCompare, null) || objectToCompare.GetType() != GetType())
            {
                return false;
            }

            var triangle = (Triangle)objectToCompare;

            return triangle.X1 == X1 && triangle.Y1 == Y1 &&
                   triangle.X2 == X2 && triangle.Y2 == Y2 &&
                   triangle.X3 == X3 && triangle.Y3 == Y3;
        }
    }
}
