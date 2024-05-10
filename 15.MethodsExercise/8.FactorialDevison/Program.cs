namespace _8.FactorialDevison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Factoriel(numberOne);
            Console.WriteLine($"{(Factoriel(numberOne)/ Factoriel(second)):f2}");
        }

        static double Factoriel(int number)
        {
            double fac1 = 1;

            for (int i = 1; i <= number; i++)
            {
                fac1 *= i;
            }
            return fac1;
        }
    }
}