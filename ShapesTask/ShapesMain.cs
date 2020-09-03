using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTask
{
    class ShapesMain
    {
        public static IShape GetMaxArea(List<IShape> shapes, int index)
        {
            shapes.Sort(new AreaComparer());
            if (index >= 0 && index < shapes.Count)
            {
                return shapes[index];
            }
            else
            {
                return null;
            }
        }

        public static IShape GetMaxPerimeter(List<IShape> shapes, int index)
        {
            shapes.Sort(new PerimeterComparer());
            if (index >= 0 && index < shapes.Count)
            {
                return shapes[index];
            }
            else
            {
                return null;
            }
        }

        static void Main()
        {
            var shapes = new List<IShape>
            {
            new Square(9),
            new Square(5),
            new Square(11),

            new Rectangle(2, 7),
            new Rectangle(3, 18),
            new Rectangle(3.5, 18.5),

            new Triangle(1, 2, 3, 4, 5, 6),
            new Triangle(0, 12, 2, 5, 2.5, 1.5),
            new Triangle(4, 5, 6.5, 0, 3, 0),

            new Circle(1),
            new Circle(2.5),
            new Circle(2.6)
            };

            var firstAreaShape = GetMaxArea(shapes, 0);
            Console.WriteLine("Первая по площади фигура: " + firstAreaShape);
            var secondAreaShape = GetMaxArea(shapes, 1);
            Console.WriteLine("Вторая по площади фигура: " + secondAreaShape);

            Console.WriteLine();

            var firstPerimeterShape = GetMaxPerimeter(shapes, 0);
            Console.WriteLine("Первая по периметру фигура: " + firstPerimeterShape);
            var secondPerimeterShape = GetMaxPerimeter(shapes, 1);
            Console.WriteLine("Вторая по периметру фигура: " + secondPerimeterShape);

            Console.WriteLine();

            Console.WriteLine("Сравнение фигур с помощью переопределенного метода Equals:");
            var circle1 = new Circle(1.9);
            var circle2 = new Circle(3.9);
            var square1 = new Square(5.6);
            var square2 = new Square(5.6);

            Console.WriteLine($"{nameof(circle1)} - {circle1}");
            Console.WriteLine($"{nameof(circle2)} - {circle2}");
            Console.WriteLine($"{nameof(square1)} - {square1}");
            Console.WriteLine($"{nameof(square2)} - {square2}");

            Console.WriteLine();

            Console.WriteLine($"Фигура {nameof(circle2)} {(circle1.Equals(circle2) ? "равна" : "не равна")} фигуре {nameof(circle1)}");
            Console.WriteLine($"Фигура {nameof(square2)} {(circle2.Equals(square2) ? "равна" : "не равна")} фигуре {nameof(circle2)}");
            Console.WriteLine($"Фигура {nameof(square1)} {(square2.Equals(square1) ? "равна" : "не равна")} фигуре {nameof(square2)}");
        }
    }
}
