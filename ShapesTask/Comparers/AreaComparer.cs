using System.Collections.Generic;
using ShapesTask.Shapes;

namespace ShapesTask.Compapers
{
    class AreaComparer : IComparer<IShape>
    {
        public int Compare(IShape shape1, IShape shape2)
        {
            if (shape1.GetArea() < shape2.GetArea())
            {
                return 1;
            }

            if (shape1.GetArea() > shape2.GetArea())
            {
                return -1;
            }

            return 0;
        }
    }
}
