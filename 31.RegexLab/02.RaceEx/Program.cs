using System.Text;
using System.Text.RegularExpressions;

namespace _02.RaceEx
{   class Participant
    {
        public Participant(string name) 
        {
            Name = name;
        }
        public string Name { get; set; }
        public uint Distance { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List <string> participantName = Console.ReadLine().Split(", ").ToList();
            List <Participant> participants = new List <Participant>();

            foreach (string p in participantName)
            {
                Participant participant = new Participant(p);
                participants.Add(participant);
            }

            string input = "";
            while ((input = Console.ReadLine()) != "end of race")
            {
                StringBuilder nameBuilder = new StringBuilder();
                string lettersPattern = $"[A-Za-z]";
                foreach (Match match in Regex.Matches(input, lettersPattern))
                {
                    nameBuilder.Append(match.Value);
                }
                uint distance = 0;
                string digitsPattern = $"\\d";
                foreach (Match match in Regex.Matches(input, digitsPattern))
                {
                    distance += uint.Parse(match.Value);
                }

                Participant foundParticipant = participants.FirstOrDefault(x => x.Name == nameBuilder.ToString());
                if (foundParticipant != null)
                {
                    foundParticipant.Distance += distance;
                }

            }
            List<Participant> first = participants.OrderByDescending(p=>p.Distance).Take(3).ToList();

            Console.WriteLine($"1st place: {first[0].Name}");
            Console.WriteLine($"2nd place: {first[1].Name}");
            Console.WriteLine($"3rd place: {first[2].Name}");
        }
    }
}