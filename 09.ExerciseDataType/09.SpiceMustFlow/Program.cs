using System;

namespace _09.SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int spice = 0;
            int days = 0;

            while (yield>=100)
            {
                days++;
                spice += yield-26;
                yield -= 10;
            }
            spice -= 26;
            if (spice<0)
            {
                spice = 0;
            }
            Console.WriteLine(days);
            Console.WriteLine(spice);
        }
    }
}
