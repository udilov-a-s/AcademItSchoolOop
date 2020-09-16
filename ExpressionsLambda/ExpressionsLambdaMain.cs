using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpressionsLambda
{
    class ExpressionsLambdaMain
    {
        static void Main(string[] args)
        {
            var person = new List<Person>
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

            var uniqueNames = person
                .Select(x => x.Name)
                .Distinct()
                .ToList();

            Console.WriteLine("Имена: " + string.Join(", ", uniqueNames));

            Console.WriteLine();

            var under18YearsAgePeoples = person
                .Where(x => x.Age < 18)
                .Select(x => x.Name)
                .ToList();

            Console.WriteLine("Люди младше 18 лет: " + string.Join(", ", under18YearsAgePeoples));

            var averageAge = person
                .Where(x => x.Age < 18)
                .Select(x => x.Age)
                .Average();

            Console.WriteLine("Средний возраст: {0:f2} лет.", averageAge);

            Console.WriteLine();

            var dictionary = person.GroupBy(x => x.Name, x => x.Age).ToDictionary(x => x.Key, x => x.Average());

            Console.WriteLine("Map:");

            foreach (var variable in dictionary)
            {
                Console.WriteLine(variable.Key + " " + variable.Value);
            }

            Console.WriteLine();

            var newPersonList = person
                .Where(x => (x.Age >= 20 && x.Age <= 45))
                .OrderByDescending(x => x.Age)
                .Select(x => x.Name)
                .ToList();

            Console.WriteLine("Люди в возрасте от 20 до 45 лет: " + string.Join(", ", newPersonList));
        }
    }
}