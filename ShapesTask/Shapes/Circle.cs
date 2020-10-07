using System;

namespace ShapesTask.Shapes
{
    class Circle : IShape
    {
        private double radius { get; set; }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(radius, 2);
        }

        public double GetHeight()
        {
            return radius * 2;
        }

        public double GetPerimeter()
        {
            return Math.PI * 2 * radius;
        }

        public double GetWidth()
        {
            return radius * 2;
        }

        public override string ToString()
        {
            return $"Круг. Площадь: {GetArea():0.####}, периметр: {GetPerimeter():0.####}, радиус: {radius:0.####}";
        }

        public override int GetHashCode()
        {
            return radius.GetHashCode();
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

            var circle = (Circle)objectToCompare;

            return circle.radius == radius;
        }
    }
}
