namespace testova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> information = new Dictionary<string, List<string>>();
            string command;
            while ((command=Console.ReadLine())!= "End")
            {
                string[] input = command.Split(" -> ").ToArray();
                string company = input[0];
                string id = input[1];

                if (!information.ContainsKey(company))
                {
                    information[company] = new List<string>();
                }
                if (!information[company].Contains(id))
                {
                    information[company].Add(id);
                }
            }
            foreach (var kvp in information)
            {
                Console.WriteLine(kvp.Key);
                foreach (var asd in kvp.Value)
                {
                    Console.WriteLine($"-- {asd}");
                }
            }

        }
    }
}