using System.Text.RegularExpressions;

namespace _02.EmojiDetector
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string emojiPattern = @"(\*{2}|:{2})(?<Emoji>[A-Z][a-z]{2,})\1";
            string coolThresholPattern = @"\d";

            List<string> coolEmojies = new List<string>();
            string input = Console.ReadLine();
            ulong coolTreshhold = 1;
            int emojiss = 0;

            foreach (Match maches in Regex.Matches(input, coolThresholPattern))
            {
                coolTreshhold *= uint.Parse(maches.Value);
            }

            foreach (Match maches in Regex.Matches(input, emojiPattern))
            {
                emojiss++;
                string emojiStr = maches.Groups["Emoji"].Value;
                ulong totalEmojiSUm = 0;
                for (int i = 0; i < emojiStr.Length; i++)
                {
                    totalEmojiSUm += (ulong)emojiStr[i];
                }
                if (totalEmojiSUm > coolTreshhold)
                {
                    coolEmojies.Add(maches.Value);
                }
            }
            Console.WriteLine($"Cool threshold: {coolTreshhold}");
            Console.WriteLine($"{emojiss} emojis found in the text. The cool ones are:");
            Console.WriteLine(string.Join("\n", coolEmojies));
        }
    }
}