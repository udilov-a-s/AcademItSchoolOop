using System;

namespace ShapesTask.Shapes
{
    class Triangle : IShape
    {
        private double x1 { get; set; }

        private double y1 { get; set; }

        private double x2 { get; set; }

        private double y2 { get; set; }

        private double x3 { get; set; }

        private double y3 { get; set; }

        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
            this.x3 = x3;
            this.y3 = y3;
        }

        public double GetArea()
        {
            var lengthA = GetSideLength(x1, y1, x2, y2);
            var lengthB = GetSideLength(x2, y2, x3, y3);
            var lengthC = GetSideLength(x3, y3, x1, y1);
            var semiperimeter = (lengthA + lengthB + lengthC) / 2;

            return Math.Sqrt(semiperimeter * (semiperimeter - lengthA)
                                           * (semiperimeter - lengthB)
                                           * (semiperimeter - lengthC));
        }

        public double GetHeight()
        {
            return Math.Max(y1, Math.Max(y2, y3)) - Math.Min(y1, Math.Min(y2, y3));
        }

        public double GetPerimeter()
        {
            var lengthA = GetSideLength(x1, y1, x2, y2);
            var lengthB = GetSideLength(x2, y2, x3, y3);
            var lengthC = GetSideLength(x3, y3, x1, y1);

            return lengthA + lengthB + lengthC;
        }

        public double GetWidth()
        {
            return Math.Max(x1, Math.Max(x2, x3)) - Math.Min(x1, Math.Min(x2, x3));
        }

        private static double GetSideLength(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public override string ToString()
        {
            var lengthA = GetSideLength(x1, y1, x2, y2);
            var lengthB = GetSideLength(x2, y2, x3, y3);
            var lengthC = GetSideLength(x3, y3, x1, y1);
            return
                $"Треугольник. Площадь: {GetArea():0.####}, периметр: {GetPerimeter():0.####}, стороны: {lengthA:0.####}, {lengthB:0.####}, {lengthC:0.####}";
        }

        public override int GetHashCode()
        {
            var prime = 19;
            var hash = 1;

            hash = prime * hash + x1.GetHashCode();
            hash = prime * hash + x2.GetHashCode();
            hash = prime * hash + x3.GetHashCode();
            hash = prime * hash + y1.GetHashCode();
            hash = prime * hash + y2.GetHashCode();
            hash = prime * hash + y3.GetHashCode();

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

            return triangle.x1 == x1 && triangle.y1 == y1 &&
                   triangle.x2 == x2 && triangle.y2 == y2 &&
                   triangle.x3 == x3 && triangle.y3 == y3;
        }
    }
}
