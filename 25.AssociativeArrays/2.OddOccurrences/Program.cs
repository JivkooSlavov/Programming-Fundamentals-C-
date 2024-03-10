using System.Diagnostics.Metrics;

namespace _2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split().Select(x => x.ToLower()).ToArray();
            Dictionary<string, int> symbols = new Dictionary<string, int>();
            for (int i = 0; i < words.Length; i++)
            {
                string currentNumber = words[i];
                if (!symbols.ContainsKey(words[i]))
                {
                    symbols[currentNumber] = 1;
                }
                else
                {
                    symbols[currentNumber]++;
                }
            }
            foreach (KeyValuePair<string, int> kvp in symbols)
            {
                if (kvp.Value %2==1)
                {
                    Console.Write($"{kvp.Key} ");
                }
            }
        }
    }
}