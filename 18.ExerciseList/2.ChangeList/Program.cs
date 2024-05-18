namespace _2.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();
            string comand = "";
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] function = comand.Split();
                if (function[0] =="Delete")
                {
                    int digit = int.Parse(function[1]);
                    numbers.RemoveAll(x => x ==digit);
                }
                else if (function[0] == "Insert")
                {
                    int digit = int.Parse(function[1]);
                    int index = int.Parse(function[2]);
                    numbers.Insert(index, digit);

                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}