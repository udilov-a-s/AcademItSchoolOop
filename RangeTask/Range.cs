using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeTask
{
    class Range
    {
        public double From { get; set; }

        public double To { get; set; }

        public Range(double from, double to)
        {
            From = from;
            To = to;
        }

        public double GetLength()
        {
            return To - From;
        }

        public bool IsInside(double number)
        {
            double epsilon = 1.0e-10;

            return (number - From >= -epsilon) && (To - number >= -epsilon);
        }

        public void Print()
        {
            Console.WriteLine("Непрерывный вещественный числовой диапазон на прямой лежит в границах от " + From + " до " + To);
        }
    }
}
