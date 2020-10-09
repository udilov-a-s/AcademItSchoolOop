using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionsLambda
{
    class ExpressionsLambdaMain
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person("Андрей", 18),
                new Person("Андрей", 10),
                new Person("Татьяна", 16),
                new Person("Максим", 49),
                new Person("Настя", 30),
                new Person("Константин", 45),
                new Person("Анна", 20),
                new Person("Ярослав", 85),
                new Person("Юлия", 32),
                new Person("Максим", 85)
            };

            var uniqueNames = persons
                .Select(x => x.Name)
                .Distinct()
                .ToList();

            Console.WriteLine("Имена: " + string.Join(", ", uniqueNames));

            Console.WriteLine();

            var under18YearsAgePeopleNames = persons
                .Where(x => x.Age < 18)
                .Select(x => x.Name)
                .ToList();

            Console.WriteLine("Люди младше 18 лет: " + string.Join(", ", under18YearsAgePeopleNames));

            var averageAge = persons
                .Where(x => x.Age < 18)
                .Select(x => x.Age)
                .Average();

            Console.WriteLine("Средний возраст: {0:f2} лет.", averageAge);

            Console.WriteLine();

            var averageAgePeopleNames = persons
                .GroupBy(x => x.Name, x => x.Age)
                .ToDictionary(x => x.Key, x => x
                .Average());

            Console.WriteLine("Map:");

            foreach (var e in averageAgePeopleNames)
            {
                Console.WriteLine(e.Key + " " + e.Value);
            }

            Console.WriteLine();

            var from20To45YearsAgePeople = persons
                .Where(x => x.Age >= 20 && x.Age <= 45)
                .OrderByDescending(x => x.Age)
                .Select(x => x.Name)
                .ToList();

            Console.WriteLine("Люди в возрасте от 20 до 45 лет: " + string.Join(", ", from20To45YearsAgePeople));
        }
    }
}