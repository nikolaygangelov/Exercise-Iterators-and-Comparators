using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    class StartUp
    {
        static void Main(string[] args)
        {

            List<Person> people = new List<Person>();
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] commandParameters = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                Person person = new Person()
                {
                    Name = commandParameters[0],
                    Age = int.Parse(commandParameters[1]),
                    Town = commandParameters[2]
                };

                people.Add(person);
            }

            int positionToCompare = int.Parse(Console.ReadLine()) - 1;

            Person personToCompare = people[positionToCompare];

            int equalCount = 0;
            int diffCount = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(personToCompare) == 0)
                {
                    equalCount++;
                }
                else
                {
                    diffCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                Console.WriteLine($"{equalCount} {diffCount} {people.Count}");
            }
        }
    }
}
