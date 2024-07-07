namespace _8.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> information = new Dictionary<string, List<string>>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] input = command.Split(" : ").ToArray();
                string course = input[0];
                string nameOfStudent = input[1];
                if (!information.ContainsKey(course))
                {
                    information[course] = new List<string>();
                }
                if (!information[course].Contains(nameOfStudent))
                {
                    information[course].Add(nameOfStudent);
                }
            }
            foreach (var kvp in information)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");
                foreach (var item in kvp.Value)
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}