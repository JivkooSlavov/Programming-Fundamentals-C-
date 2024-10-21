namespace _02.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            string command = "";
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] array = command.Split();
                string function = array[0];
                int value = int.Parse(array[1]);
                if (function == "Add")
                {
                    numbers.Add(value);
                }
                else if (function == "Remove")
                {
                    if (numbers.Contains(value))
                    {
                        numbers.Remove(value);
                    }
                }
                else if (function == "Replace")
                {
                    int replacement = int.Parse(array[2]);
                    if (numbers.Contains(value))
                    {
                        int newIndex =numbers.IndexOf(value);
                        numbers.Insert(newIndex, replacement);
                        numbers.RemoveAt(newIndex + 1);
                    }
                }
                else if (function == "Collapse")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        if (numbers[i]<value)
                        {
                            numbers.RemoveAt(i);
                        }
                    }
                }
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}