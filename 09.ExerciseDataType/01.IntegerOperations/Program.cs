using System;

namespace _01.IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int fourt = int.Parse(Console.ReadLine());
            int total = ((first + second) / third) * fourt;
            Console.WriteLine(total);
        }
    }
}
