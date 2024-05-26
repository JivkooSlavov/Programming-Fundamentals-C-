namespace _2.ArrayModifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
           
            string command = "";
            while ((command=Console.ReadLine())!="end")
            {
                string[] array = command.Split();
                string function = array[0];
                if (function== "swap")
                {
                    int indexOne = int.Parse(array[1]);
                    int indexTwo = int.Parse(array[2]);

                    int save = numbers[indexOne];
                    numbers[indexOne] = numbers[indexTwo];
                    numbers[indexTwo] = save;

                }
                else if (function == "multiply")
                {
                    int indexOne = int.Parse(array[1]);
                    int indexTwo = int.Parse(array[2]);

                    numbers[indexOne] *= numbers[indexTwo];
                }
                else if (function == "decrease")
                {
                    for (int i = 0; i < numbers.Count; i++)
                    {
                        numbers[i] -= 1;
                    }
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}