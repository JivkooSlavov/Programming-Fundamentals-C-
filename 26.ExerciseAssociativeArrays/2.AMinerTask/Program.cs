namespace _2.AMinerTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourceMap = new Dictionary<string, int>();
            string input;
            while ((input = Console.ReadLine()) != "stop") 
            {
                
                if (!resourceMap.ContainsKey(input))
                {
                    resourceMap.Add(input, 0);
                }
                int value = int.Parse(Console.ReadLine());
                resourceMap[input] += value;

            }
            foreach (var item in resourceMap)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}