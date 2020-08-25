using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeTask
{
    class RangeMain
    {
        public static double PrintAndRead(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void Main()
        {
            double from = PrintAndRead("Введите начало диапазона: ");

            double to;

            for (; ; )
            {
                to = PrintAndRead("Введите конец диапазона: ");

                double epsilon = 1.0e-10;

                if (to - from > epsilon)
                {
                    break;
                }

                Console.WriteLine("Введите корректный конец диапазона!");
            }

            Range range = new Range(from, to);
            range.Print();

            double rangeLength = range.GetLength();
            Console.WriteLine("Длина диапазона равна: " + rangeLength);

            double number = PrintAndRead("Введите любое число, для проверки принадлежности его к данному диапазону: ");

            if (range.IsInside(number))
            {
                Console.WriteLine("Это число лежит в данном диапазоне!");
            }
            else
            {
                Console.WriteLine("Это число не входит в данный диапазон!");
            }
        }
    }
}
