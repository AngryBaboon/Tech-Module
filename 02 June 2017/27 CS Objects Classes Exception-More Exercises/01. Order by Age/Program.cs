using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Order_by_Age
{
    class Program
    {
        class Person
        {
            public string Name { get; set; }
            public string Id { get; set; }
            public int Age { get; set; }
        }

        static void Main(string[] args)
        {
            var classPerson = new Person();
            var personList = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine().Split();

                if (input[0] == "End") break;

                var name = input[0];
                var id = input[1];
                var age = int.Parse(input[2]);

                classPerson = new Person()
                {
                    Name = name,
                    Id = id,
                    Age = age
                };

                personList.Add(classPerson);
            }

            personList = personList.OrderBy(a => a.Age).ToList();

            foreach (var person in personList)
            {
                Console.WriteLine($"{person.Name} with ID: {person.Id} is {person.Age} years old.");
            }
        }
    }
}
