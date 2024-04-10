namespace _6.EqualSums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int left = 0;
                int right = 0;
                for (int j = 0; j < i; j++)
                {
                    left += numbers[j]; 
                }
                for (int k = i+1; k < numbers.Length; k++)
                {
                    right += numbers[k];
                }
                if (left==right)
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("no");
        }
    }
}