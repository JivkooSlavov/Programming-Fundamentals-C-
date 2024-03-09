using System;

namespace _12.SpecialNumberRefactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 0;
            bool isSpecialNum = false;
            for (int i = 1; i <= n; i++)
            {
                number = i;
                while (i > 0)
                {
                    sum += i % 10;
                    i = i / 10;
                }
                isSpecialNum = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine("{0} -> {1}", number, isSpecialNum);
                sum = 0;
                i = number;
            }
        }
    }
}
