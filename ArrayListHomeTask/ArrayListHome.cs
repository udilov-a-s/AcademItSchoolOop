using System;
using System.Collections.Generic;
using System.IO;

namespace ArrayListHomeTask
{
    class ArrayListHome
    {
        static void Main(string[] args)
        {
            List<string> strings = new List<string>();

            try
            {
                using (StreamReader reader = new StreamReader("..\\..\\input.txt"))
                {
                    string currentLine;

                    while ((currentLine = reader.ReadLine()) != null)
                    {
                        strings.Add(currentLine);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Файл не найден.");
            }

            Console.WriteLine(string.Join(", ", strings));

            Console.WriteLine();

            List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    numbers.RemoveAt(i);
                    i--;
                }
            }

            Console.WriteLine("Список нечетных чисел: " + string.Join(", ", numbers));

            Console.WriteLine();

            List<int> listWithRepeats = new List<int> { 1, 5, 2, 1, 3, 5 };
            List<int> listWithoutRepeats = new List<int>(listWithRepeats.Count);

            foreach (int n in listWithRepeats)
            {
                if (!listWithoutRepeats.Contains(n))
                {
                    listWithoutRepeats.Add(n);
                }
            }

            Console.WriteLine("Список без повторов: " + string.Join(", ", listWithoutRepeats));
        }
    }
}
