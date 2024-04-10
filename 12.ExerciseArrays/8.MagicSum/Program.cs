using System;

namespace _8.MagicSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int magicNumber = int.Parse(Console.ReadLine());
            int[] newArr = new int[2]; 

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i+1; j < numbers.Length; j++)
                {
                    if (numbers[i] + numbers[j] == magicNumber)
                    {
                            newArr[0] = numbers[i];
                            newArr[1] = numbers[j];
                            Console.WriteLine(string.Join(" ", newArr));
                    }
                }
            }
        }
    }
}