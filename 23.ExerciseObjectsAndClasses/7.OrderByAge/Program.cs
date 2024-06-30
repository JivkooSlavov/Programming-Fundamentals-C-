using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data;

namespace _7.OrderByAge
{
    class Person
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{Name} with ID: {Id} is {Age} years old.";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> informations = new List<Person>();
            string command = "";
            while ((command = Console.ReadLine()) != "End")
            {
                string[] information = command.Split();
                string name = information[0];
                string id = information[1];
                int age = int.Parse(information[2]);

                Person personFound = informations.FirstOrDefault(x => x.Id == id);

                if (personFound != null)
                {
                    personFound.Age = age;
                    personFound.Name = name;
                }
                else
                {
                    Person person = new Person();
                    person.Age = age;
                    person.Name = name;
                    person.Id = id;
                    informations.Add(person);
                }

            }
            List<Person> orderedPersons = informations.OrderBy(person => person.Age).ToList();
            foreach (Person person in orderedPersons)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}