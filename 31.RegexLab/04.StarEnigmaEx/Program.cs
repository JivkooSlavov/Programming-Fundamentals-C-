using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.StarEnigmaEx
{
    class Messange
    {
        public string PlanetName { get; set; }
        public uint Population { get; set; }

        public string AttackType { get; set; }

        public uint SolidierCount { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Messange> messanges = new List<Messange>();
            int numberOfMessanges = int.Parse(Console.ReadLine());
            string starPattern = @"[SsTtAaRr]";
            string msgPattern = @"\@(?<planet>[A-Za-z]+)[^@\-!:>]*:(?<population>\d+)[^@\-!:>]*\!(?<type>[A|D])[^@\-!:>]*\!\->(?<soldier>\d+)[^\@\-\!\:\>]*";

            for (int i = 0; i < numberOfMessanges; i++)
            {
                string encryptMsg = Console.ReadLine();
                int descriptionKey = Regex.Matches(encryptMsg, starPattern).Count;

                StringBuilder descriptionMessange = new StringBuilder();
                for (int j = 0; j < encryptMsg.Length; j++)
                {
                    char symbols = (char)(encryptMsg[j] - descriptionKey);
                    descriptionMessange.Append(symbols);
                }

                string encrypteMsg = descriptionMessange.ToString();
                MatchCollection matches = Regex.Matches(encrypteMsg, msgPattern);
                if (!Regex.IsMatch(encrypteMsg, msgPattern))
                {
                    continue;
                }
                foreach (Match match in matches)
                {
                    Messange messange = new Messange();
                    messange.PlanetName = match.Groups["planet"].Value;
                    messange.Population = uint.Parse(match.Groups["population"].Value);
                    messange.AttackType = match.Groups["type"].Value;
                    messange.SolidierCount = uint.Parse(match.Groups["soldier"].Value);
                    messanges.Add(messange);
                }
            }

            var planets = messanges.Where(m => m.AttackType == "A")
       .OrderBy(m => m.PlanetName)
       .ToList();

            Console.WriteLine($"Attacked planets: {planets.Count}");
            foreach (Messange messange in planets)
            {
                Console.WriteLine($"-> {messange.PlanetName}");
            }

            planets = messanges.Where(m => m.AttackType == "D")
                .OrderBy(m => m.PlanetName)
                .ToList();

            Console.WriteLine($"Destroyed planets: {planets.Count}");
            planets.ForEach(m => Console.WriteLine($"-> {m.PlanetName}"));

        }
    }
}