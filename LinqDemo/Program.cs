using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var persons = GetPersons();
            var numbersArray = Enumerable.Range(1, 10).ToArray();
            var numbersList = Enumerable.Range(1, 10).ToList();

            var str = "Hej";
            var fullStr = str.Add("Då");
            var fullStr2 = str.Add("Då", "Vi", "Ses", "Imorgon");

            Console.WriteLine(fullStr2);

            int x = 1;
            x.IntExt();


            Console.WriteLine("-----------------");

            var longNames = persons.ReturnIfTrue(TestNameLength);
            var longNames2 = persons.ReturnIfTrue(p => p.Name.Length > 10);
            var longNameAges = persons.ReturnIfTrue(p => p.Name.Length > 10)
                                    .Select(p => p.Age);

            var numbersInRange = numbersArray.ReturnIfTrue(n => n < 5).Count();
            var numbersInRange2 = numbersArray.ReturnIfTrue(n => n < 5);

            var result = persons.Where(p => p.Name.StartsWith("S"))
                                .Where(p => p.Name.EndsWith("a"))
                                .Select(p => new PersonDTO
                                {
                                    Name = p.Name,
                                    NamesLength = p.Name.Length

                                });
                                
                                //.Select(p => p.Age);
                                //.Sum();
                                //.Min();
                                //.Average();



            Console.ReadKey();
        }

        private static bool TestNameLength(Person pers)
        {
            return pers.Name.Length > 10;
        }

        private static IEnumerable<Person> GetPersons()
        {
            return new List<Person>
                {
                new("Nisse", 20),
                new("Nisse", 21),
                new("Nisse", 22),
                new("Nisse", 23),
                new("Nisse", 24),
                new("Nisse", 24),
                new("Nisse", 26),
                new("Pelle" ,65),
                new("Pelle" ,60),
                new("Pelle" ,62),
                new("Olle" , 66),
                new("Sara" , 54),
                new("Ida" ,  36),
                new("Fia",   45),
                new("Sophia-Magdalena", 32),
            };
        }
    }
}
