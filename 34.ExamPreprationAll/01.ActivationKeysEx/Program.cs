using System.ComponentModel;

namespace _01.ActivationKeysEx
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string activationKey = Console.ReadLine();

            string input = "";
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] line = input.Split(">>>");
                string action = line[0];

                if (action == "Contains")
                {
                    string substring = line[1];
                    if (!activationKey.Contains(substring))
                    {
                        Console.WriteLine("Substring not found!");
                        continue;
                    }
                    Console.WriteLine($"{activationKey} contains {substring}");
                }
                else if (action == "Flip")
                {
                    string alpha = line[1];
                    int startIndex = int.Parse(line[2]);
                    int endIndex = int.Parse(line[3]);
                    if (alpha == "Upper")
                    {
                        string first = activationKey.Substring(0, startIndex);
                        string middle = activationKey.Substring(startIndex, endIndex-startIndex).ToUpper();
                        string final = activationKey.Substring(endIndex);
                        activationKey = first + middle + final;
                        Console.WriteLine(activationKey);
                    }
                    else if (alpha == "Lower")
                    {
                        string first = activationKey.Substring(0, startIndex);
                        string middle = activationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                        string final = activationKey.Substring(endIndex);
                        activationKey = first + middle + final;
                        Console.WriteLine(activationKey);
                    }
                }
                else if (action == "Slice")
                {
                    int startIndex = int.Parse(line[1]);
                    int endIndex = int.Parse(line[2]);
                    activationKey = activationKey.Remove(startIndex, endIndex - startIndex);
                    Console.WriteLine(activationKey);
                }
            }
            Console.WriteLine($"Your activation key is: {activationKey}");
        }
    }
}