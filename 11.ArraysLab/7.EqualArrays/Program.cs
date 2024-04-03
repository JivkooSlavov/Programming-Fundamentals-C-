namespace _07.EqualArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] numbers2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            ///int counter = 0;
            int totalSum = 0;
            bool areSame = true;
            for (int i = 0; i < numbers1.Length; i++)
            {
                totalSum += numbers1[i];
                if (numbers1[i] != numbers2[i])
                {
                   /// counter++;
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    areSame = false;
                    break;

                }
            }
            if (areSame)
            {
                Console.WriteLine($"Arrays are identical. Sum: {totalSum}");
            }

        }
    }
}