using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace RangeStarTask
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
            Console.WriteLine("(" + From + "; " + To + ")");
        }

        public bool hasIntersection(Range range)
        {
            return From < range.To && range.From < To;
        }

        public Range getIntersection(Range range)
        {
            if (hasIntersection(range))
            {
                return new Range(Math.Max(From, range.From), Math.Min(To, range.To));
            }

            return null;
        }

        public Range[] getUnion(Range range)
        {
            if ((From <= range.To) && (range.From <= To))
            {
                return new Range[] { new Range(Math.Min(From, range.From), Math.Max(To, range.To)) };
            }

            return new Range[] { new Range(From, To), new Range(range.From, range.To) };
        }

        public Range[] getDifference(Range range)
        {
            if (!hasIntersection(range))
            {
                return new Range[] { new Range(From, To) };
            }

            if (From >= range.From && To <= range.To)
            {
                return new Range[0];
            }

            if (From < range.From && To > range.To)
            {
                return new Range[] { new Range(From, range.From), new Range(range.To, To) };
            }

            if (From < range.From && To <= range.To)
            {
                return new Range[] { new Range(From, range.From) };
            }

            return new Range[] { new Range(range.To, To) };
        }
    }
}


