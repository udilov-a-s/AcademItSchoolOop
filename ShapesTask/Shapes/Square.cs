using System;

namespace ShapesTask.Shapes
{
    class Square : IShape
    {
        private double sideLenght;

        public Square(double sideLenght)
        {
            this.sideLenght = sideLenght;
        }

        public double GetArea()
        {
            return Math.Pow(sideLenght, 2);
        }

        public double GetHeight()
        {
            return sideLenght;
        }

        public double GetWidth()
        {
            return sideLenght;
        }

        public double GetPerimeter()
        {
            return sideLenght * 4;
        }

        public override string ToString()
        {
            return $"Квадрат. Площадь: {GetArea():0.####}, периметр: {GetPerimeter():0.####}, сторона: {GetWidth():0.####}";
        }

        public override int GetHashCode()
        {
            return sideLenght.GetHashCode();
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

            return square.sideLenght == sideLenght;
        }
    }
}
