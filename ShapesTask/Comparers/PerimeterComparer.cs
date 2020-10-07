using System.Collections.Generic;
using ShapesTask.Shapes;

namespace ShapesTask.Compapers
{
    class PerimeterComparer : IComparer<IShape>
    {
        public int Compare(IShape shape1, IShape shape2)
        {
            if (shape1.GetPerimeter() < shape2.GetPerimeter())
            {
                return 1;
            }

            if (shape1.GetPerimeter() > shape2.GetPerimeter())
            {
                return -1;
            }

            return 0;
        }
    }
}
