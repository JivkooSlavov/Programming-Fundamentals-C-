using System.Text;

namespace _001.ExtractPersonInformation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            for (int i = 0; i < lines; i++)
            {
                string input = Console.ReadLine();
                int startIndexName = input.IndexOf('@');
                int endIndexName = input.IndexOf('|');
                string name = input.Substring(startIndexName + 1, endIndexName - startIndexName - 1 );
                int startIndexAge = input.IndexOf('#');
                int endIndexAge = input.IndexOf('*');
                string age = input.Substring(startIndexAge + 1, endIndexAge - startIndexAge - 1);
                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}