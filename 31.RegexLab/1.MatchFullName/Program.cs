using System.Text.RegularExpressions;

namespace _31.RegexLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string names = Console.ReadLine();
            string pattern = @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b";
            Regex regex = new Regex(pattern);
            MatchCollection matchedName = regex.Matches(names);
            foreach (Match maches in matchedName)
            {
                Console.Write(maches + " ");
            }
        }
    }
}