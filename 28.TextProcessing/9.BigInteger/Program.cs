using System;

class Program
{
    static void Main()
    {
        string bigNumberString = Console.ReadLine();
        System.Numerics.BigInteger bigNumber = System.Numerics.BigInteger.Parse(bigNumberString);

        int singleDigit = int.Parse(Console.ReadLine());

        System.Numerics.BigInteger product = bigNumber * singleDigit;

        Console.WriteLine(product);
    }
}