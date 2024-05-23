using System;

namespace _7.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string [] stringArrays = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);
            List<string> result = new List<string>();

            for (int i = stringArrays.Length - 1; i >= 0; i--)
            {
                string sequence = stringArrays[i];
                string[] array = sequence.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                result.AddRange(array);
            }



            Console.WriteLine(string.Join(" ", result));
        }
    }
}