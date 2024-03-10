using System.Security.Cryptography.X509Certificates;

namespace _1.CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            SortedDictionary<int, int> counts = new SortedDictionary<int, int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if (!counts.ContainsKey(numbers[i]))
                {
                    counts[currentNumber] = 1;
                }
                else
                {
                    counts[currentNumber]++;
                }
            }
            foreach (KeyValuePair<int, int> kvp in counts)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}