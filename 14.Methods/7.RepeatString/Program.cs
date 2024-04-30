namespace _7.RepeatString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repeat = int.Parse(Console.ReadLine());

            string result = "";
            result = FinishResult(input, repeat, result);
            Console.WriteLine(result);
        }

        static string FinishResult(string input, int repeat, string result)
        {
            for (int i = 0; i < repeat; i++)
            {
                result += input;
            }

            return result;
        }
    }
}