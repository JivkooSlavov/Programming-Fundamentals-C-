using System.Runtime.ExceptionServices;

namespace _2.GaussTrick
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();

            List < int> result = new List<int>();   

            for (int i = 0; i < numbers.Count/2; i++)
            {
                int first = numbers[i];
                int last = numbers[numbers.Count - i - 1];
                result.Add(first+last);
            }
            if (numbers.Count%2!=0)
            {
                int middleNumber = numbers.Count / 2;
                result.Add(numbers[middleNumber]);
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}