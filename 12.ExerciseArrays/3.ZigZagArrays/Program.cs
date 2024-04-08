using System;

namespace _3.ZigZagArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArr = new int[n];
            int[] secondArr = new int[n];

            for (int i = 0; i < n; i++)
            {
                int[] currentInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (i % 2==0)
                {
                    firstArr[i] = currentInput[0];
                    secondArr[i] = currentInput[1];
                }
                else
                {
                    secondArr[i] = currentInput[0];
                    firstArr[i] = currentInput[1];
                }
            }
            Console.WriteLine(string.Join(" ", firstArr));
            Console.WriteLine(string.Join(" ", secondArr));
        }
    }
}