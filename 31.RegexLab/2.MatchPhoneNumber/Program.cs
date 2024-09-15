using System.Text.RegularExpressions;

namespace _2.MatchPhoneNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\+359( |-)2\1\d{3}\1\d{4}\b";
            Regex rege = new Regex(pattern);
            MatchCollection matches = rege.Matches(input);

            Console.WriteLine(string.Join(", ", matches));
        }
    }
}