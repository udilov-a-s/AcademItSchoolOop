namespace ShapesTask.Shapes
{
    class Rectangle : IShape
    {
        private double width { get; set; }

        private double height { get; set; }

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetWidth()
        {
            return width;
        }

        public double GetHeight()
        {
            return height;
        }

        public double GetPerimeter()
        {
            return 2 * (width + height);
        }

        public override string ToString()
        {
            return $"Прямоугольник. Площадь: {GetArea():0.####}, периметр: {GetPerimeter():0.####}, ширина: {width:0.####}, высота {height:0.####}";
        }

        public override int GetHashCode()
        {
            var prime = 19;
            var hash = 1;

            hash = prime * hash + width.GetHashCode();
            hash = prime * hash + height.GetHashCode();

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

            var rectangle = (Rectangle)objectToCompare;

            return rectangle.width == width && rectangle.height == height;
        }
    }
}
