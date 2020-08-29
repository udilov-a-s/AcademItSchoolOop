using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RangeStarTask
{
    class RangeMain
    {
        public static double PrintAndRead(string message)
        {
            Console.Write(message);
            return Convert.ToDouble(Console.ReadLine());
        }

        public static void PrintRangeArray(Range[] rangeArray)
        {
            foreach (Range range in rangeArray)
            {
                Console.WriteLine("({0}; {1})", range.From, range.To);
            }
        }

        public static void Main()
        {
            Console.WriteLine("Принадлежность числа интервалу. Код команды:  1");
            Console.WriteLine("Пересечение интервалов.         Код команды:  2");
            Console.WriteLine("Объединение интервалов.         Код команды:  3");
            Console.WriteLine("Вычитание интервалов.           Код команды:  4");
            Console.WriteLine("----------------------------");

            Console.Write("Введите код команды:  ");
            int commandCode = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("----------------------------");

            if (commandCode == 1 || commandCode == 2 || commandCode == 3 || commandCode == 4)
            {
                if (commandCode == 1)
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
                else
                {
                    double from1 = PrintAndRead("Введите начало первого интервала: ");

                    double to1;

                    for (; ; )
                    {
                        to1 = PrintAndRead("Введите конец первого интервала: ");

                        double epsilon = 1.0e-10;

                        if (to1 - from1 > epsilon)
                        {
                            break;
                        }

                        Console.WriteLine("Введите корректный конец интервала!");
                    }

                    Range range1 = new Range(from1, to1);

                    double from2 = PrintAndRead("Введите начало второго интервала: ");

                    double to2;

                    for (; ; )
                    {
                        to2 = PrintAndRead("Введите конец второго интервала: ");

                        double epsilon = 1.0e-10;

                        if (to2 - from2 > epsilon)
                        {
                            break;
                        }

                        Console.WriteLine("Введите корректный конец интервала!");
                    }

                    Range range2 = new Range(from2, to2);

                    if (commandCode == 2)
                    {
                        Range intersection = range1.getIntersection(range2);

                        Console.Write("Результат операции: ");

                        if (intersection != null)
                        {
                            intersection.Print();
                        }
                        else
                        {
                            Console.WriteLine("пересечения нет");
                        }
                    }
                    else if (commandCode == 3)
                    {
                        Range[] union = range1.getUnion(range2);

                        Console.WriteLine("Результат операции: ");

                        PrintRangeArray(union);
                    }
                    else
                    {
                        Range[] difference = range1.getDifference(range2);

                        if (difference.Length == 0)
                        {
                            Console.WriteLine("Результат операции: 0 отрезков");
                        }
                        else
                        {
                            Console.WriteLine("Результат операции: ");

                            PrintRangeArray(difference);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Результат операции: ");
                Console.WriteLine("Вы ввели неизвестную команду!");
            }

        }
    }
}
