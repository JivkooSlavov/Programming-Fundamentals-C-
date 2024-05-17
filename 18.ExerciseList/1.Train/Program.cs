namespace _18.ExerciseList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            int capacity = int.Parse(Console.ReadLine());
            string comand = "";
            while ((comand = Console.ReadLine()) != "end")
            {
                string[] function = comand.Split();
                
                if (function[0] == "Add")
                {
                    int digit = int.Parse(function[1]);
                    numbers.Add(digit);
                }
                else
                {
                    int digit = int.Parse(function[0]);
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (digit + numbers[i] <= capacity)
                        {
                            numbers[i] += digit;
                            break;
                        }
                    }
                }

            }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}