namespace _7.ListManipulationAdvanced
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
              .Split()
              .Select(int.Parse)
              .ToList();
            bool change = false;
            string line = "";
            while ((line = Console.ReadLine()) != "end")
            {
                string[] lineTokens = line.Split().ToArray();
                string command = lineTokens[0];

                if (command== "Contains")
                {
                    int digit = int.Parse(lineTokens[1]);
                    if (numbers.Contains(digit)==true)
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                }
                else if (command=="PrintOdd")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 != 0).ToList()));
                }
                else if (command == "PrintEven")
                {
                    Console.WriteLine(string.Join(" ", numbers.Where(x => x % 2 == 0).ToList()));
                }
                else if (command=="GetSum")
                {
                    Console.WriteLine(numbers.Sum());
                }
                else if (command=="Filter")
                {  
                    string function = lineTokens[1];    
                    int filterNumber = int.Parse(lineTokens[2]);
                    if (function == ">")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x > filterNumber).ToList()));
                    }
                    else if (function == "<")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x < filterNumber).ToList()));
                    }
                    else if (function == ">=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x >= filterNumber).ToList()));
                    }
                    else if (function == "<=")
                    {
                        Console.WriteLine(string.Join(" ", numbers.Where(x => x <= filterNumber).ToList()));
                    }

                }
                if (command == "Add")
                {
                    int digit = int.Parse(lineTokens[1]);
                    numbers.Add(digit);
                    change = true;
                }
                else if (command == "Insert")
                {
                    int digit = int.Parse(lineTokens[1]);
                    int index = int.Parse(lineTokens[2]);
                    numbers.Insert(index, digit);
                    change = true;
                }
                else if (command == "Remove")
                {
                    int digit = int.Parse(lineTokens[1]);
                    numbers.Remove(digit);
                    change = true;
                }
                else if (command == "RemoveAt")
                {
                    int index = int.Parse(lineTokens[1]);
                    numbers.RemoveAt(index);
                    change = true;
                }
            }
            if (change==true)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}