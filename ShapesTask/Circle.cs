using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTask
{
    class Circle : IShape
    {
        private readonly double Radius;

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public double GetHeight()
        {
            return Radius * 2;
        }

        public double GetPerimeter()
        {
            return Math.PI * 2 * Radius;
        }

        public double GetWidth()
        {
            return Radius * 2;
        }

        public override string ToString()
        {
            return $"Круг. Площадь: {GetArea():0.####}, периметр: {GetPerimeter():0.####}, радиус: {Radius:0.####}";
        }

        public override int GetHashCode()
        {
            return Radius.GetHashCode();
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

            return circle.Radius == Radius;
        }
    }
}
