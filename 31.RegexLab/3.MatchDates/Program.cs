using System.Text.RegularExpressions;

namespace _3.MatchDates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"(?<day>\d{2})(\.|-|/)(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})";
            Regex reg = new Regex(pattern);
            MatchCollection matches = reg.Matches(input);
            foreach (Match match in matches)
            {
                Console.WriteLine($"Day: {match.Groups["day"]}, Month: {match.Groups["month"]}, Year: {match.Groups["year"]}");
            }
        }
    }
}