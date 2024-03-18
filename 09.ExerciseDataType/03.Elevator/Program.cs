using System;

namespace _03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacityOfPersons = int.Parse(Console.ReadLine());
            int courses = (int)Math.Ceiling((decimal)persons / capacityOfPersons);
            Console.WriteLine(courses);
        }
    }
}
