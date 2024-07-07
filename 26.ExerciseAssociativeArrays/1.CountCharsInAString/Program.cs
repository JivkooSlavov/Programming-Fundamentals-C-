using System.Collections.Generic;

namespace _1.CountCharsInAString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<char, int> array = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];
                if (symbol == ' ')
                {
                    continue;
                }
                if (!array.ContainsKey(symbol))
                {
                    array.Add(symbol, 0);
                }
                array[symbol] ++;
            }
            foreach (var kvp in array)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}