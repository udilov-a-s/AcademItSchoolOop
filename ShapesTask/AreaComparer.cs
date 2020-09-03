using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesTask
{
    class AreaComparer : IComparer<IShape>
    {
        public int Compare(IShape shape1, IShape shape2)
        {
            if (shape1 == null && shape2 == null)
            {
                return 0;
            }

            if (shape1 == null)
            {
                return 1;
            }

            if (shape2 == null)
            {
                return -1;
            }

            return shape2.GetArea().CompareTo(shape1.GetArea());
        }
    }
}
