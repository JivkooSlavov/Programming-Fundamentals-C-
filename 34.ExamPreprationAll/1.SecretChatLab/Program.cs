namespace _34.ExamPreprationAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string messange = Console.ReadLine();

            string input = "";
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] hiddenMessange = input.Split(":|:");
                string command = hiddenMessange[0];

                if (command == "InsertSpace")
                {
                    int index = int.Parse(hiddenMessange[1]);
                    messange = messange.Insert(index, " ");                    
                }
                else if (command == "Reverse")
                {
                    string substring = hiddenMessange[1];
                    int substringIndex = messange.IndexOf(substring);
                    if (substringIndex <0)
                    {
                        Console.WriteLine("error");
                        continue;
                    }
                    messange = messange.Remove(substringIndex, substring.Length);
                    string newSubstring = new string (substring.Reverse().ToArray());
                    messange += newSubstring;
                }
                else if (command == "ChangeAll")
                {
                    string substring = hiddenMessange[1];
                    string replacement = hiddenMessange[2];
                    messange = messange.Replace(substring, replacement);
                }
                Console.WriteLine(messange);
            }
            Console.WriteLine($"You have a new text message: {messange}");
        }
    }
}