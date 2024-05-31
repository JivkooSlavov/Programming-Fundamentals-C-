using System;
using System.Linq;

namespace TheLift
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] operations = command.Split();
                int index = int.Parse(operations[1]);
                if (operations[0] == "Shoot")
                {
                    int power = int.Parse(operations[2]);
                    if (index >= 0 && index < input.Count)
                    {
                        input[index] -= power;
                        if (input[index] <= 0)
                        {
                            {
                                input.RemoveAt(index);
                            }
                        }
                    }
                }
                else if (operations[0] == "Add")
                {
                    int value = int.Parse(operations[2]);
                    if (index >= 0 && index < input.Count)
                    {
                        input.Insert(index, value);
                    }
                    else
                    {
                        Console.WriteLine("Invalid placement!");
                    }
                    ///    0 4 
                }  ///// { 1 , 3 , 4 ,5 ,6 }
                else if (operations[0] == "Strike")
                {
                    int radius = int.Parse(operations[2]);
                    if (index + radius <= input.Count - 1 && index - radius >= 0 && index >= 0 && index < input.Count)
                    {
                        for (int i = index + radius; i >= index - radius; i--)
                        {
                            input.RemoveAt(i);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Strike missed!");
                    }
                }
            }
            Console.WriteLine(string.Join("|", input));
        }

    }

}