namespace _3.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            var dictionary = new Dictionary<string, string>();
            for (int i = 0; i < input; i++)
            {
                string word = Console.ReadLine();
                string synonim = Console.ReadLine();
                if (!dictionary.ContainsKey(word))
                {
                    dictionary[word] = synonim;
                }
                else
                {
                    dictionary[word] += ", " + synonim;
                }
            }
            foreach (KeyValuePair<string, string> kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}