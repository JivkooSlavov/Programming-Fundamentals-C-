using System;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace _4.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = "";
            while ((command=Console.ReadLine())!="End")
            {
                string[] operation = command.Split();
                if (operation[0]=="Add")
                {
                    numbers.Add(int.Parse(operation[1]));
                }
                else if (operation[0] == "Insert")
                {
                    int number = int.Parse(operation[1]);
                    int index = int.Parse(operation[2]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.Insert(index, number);
                    }
                }
                else if (operation[0] == "Remove")
                {
                    int index = int.Parse(operation[1]);
                    if (index < 0 || index >= numbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                    }
                    else
                    {
                        numbers.RemoveAt(int.Parse(operation[1]));
                    }
   
                }
                else if (operation[0] == "Shift")
                {
                    int count = int.Parse(operation[2]);
                    count %=numbers.Count;

                    if (operation[1] == "left")
                    {
                        List<int> shiftedPart = numbers.GetRange(0, count);
                        numbers.RemoveRange(0, count);
                        numbers.InsertRange(numbers.Count, shiftedPart);
                    }
                    else if (operation[1] == "right")
                    {
                        List<int> shiftedPart = numbers.GetRange(numbers.Count-count, count);
                        numbers.RemoveRange(numbers.Count - count, count);
                        numbers.InsertRange(0, shiftedPart);

                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}