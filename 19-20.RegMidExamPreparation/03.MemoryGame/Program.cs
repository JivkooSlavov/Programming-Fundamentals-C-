namespace _03.MemoryGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> symbols = Console.ReadLine().Split().ToList();

            int movesCounter = 0;
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] operations = command.Split();
                int index1 = int.Parse(operations[0]);
                int index2 = int.Parse((operations[1]));
                movesCounter++;

                if (index1 == index2 || (index1 < 0 || index1 >= symbols.Count) || (index2 < 0 || index2 >= symbols.Count))
                {
                    string newSymbol = $"-{movesCounter}a";
                    List<string> newElements = new List<string>() { newSymbol, newSymbol };
                    int middle = symbols.Count / 2;
                    symbols.InsertRange(middle, newElements);
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                }
                else
                {
                    if (symbols[index1] == symbols[index2])
                    {
                        Console.WriteLine($"Congrats! You have found matching elements - {symbols[index1]}!");
                        if (index1 > index2)
                        {
                            symbols.RemoveAt(index1);
                            symbols.RemoveAt(index2);
                        }
                        else if (index1 < index2)
                        {
                            symbols.RemoveAt(index2);
                            symbols.RemoveAt(index1);
                        }
                    }
                    else if (symbols[index1] != symbols[index2])
                    {
                        Console.WriteLine("Try again!");
                    }
                    if (symbols.Count == 0)
                    {
                        Console.WriteLine($"You have won in {movesCounter} turns!");
                        return;
                    }
                }
            }
            Console.WriteLine("Sorry you lose :(");
            Console.WriteLine(string.Join(" ", symbols));
        }
    }
}