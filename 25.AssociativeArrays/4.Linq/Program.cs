namespace _4.Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split().ToList().Where(x=>x.Length%2== 0).ToList();
            Console.Write(string.Join("\n", input));

        }
    }
}