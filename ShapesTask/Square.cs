using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTask
{
    class Square : IShape
    {
        private readonly double SideLenght;

        public Square(double sideLenght)
        {
            SideLenght = sideLenght;
        }

        public double GetArea()
        {
            return Math.Pow(SideLenght, 2);
        }

        public double GetHeight()
        {
            return SideLenght;
        }

        public double GetWidth()
        {
            return SideLenght;
        }

        public double GetPerimeter()
        {
            return SideLenght * 4;
        }

        public override string ToString()
        {
            return $"Квадрат. Площадь: {GetArea():0.####}, периметр: {GetPerimeter():0.####}, сторона: {GetWidth():0.####}";
        }

        public override int GetHashCode()
        {
            return SideLenght.GetHashCode();
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

            var square = (Square)objectToCompare;

            return square.SideLenght == SideLenght;
        }
    }
}
