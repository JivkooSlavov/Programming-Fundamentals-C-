using System.Numerics;

namespace _2.BigFactoriel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            BigInteger big = 1;
            for (int i = 1; i <= number; i++)
            {
                big *= i;
            }
            Console.WriteLine(big);
        }
    }
}