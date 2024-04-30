namespace _8.MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double totalResult = Math.Pow(numbers, power);
            Console.WriteLine(totalResult);

        }
    }
}