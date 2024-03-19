using System;

namespace _07.WaterOverFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfLines = int.Parse(Console.ReadLine());
            int capacityOfTank = 255;
            int allDosesWater = 0;

            for (int i = 0; i < numbersOfLines; i++)
            {
                int doseOfWater = int.Parse(Console.ReadLine());
                allDosesWater += doseOfWater;
                if (allDosesWater>capacityOfTank)
                {
                    Console.WriteLine("Insufficient capacity!");
                    allDosesWater -= doseOfWater;
                }
            }
            if (capacityOfTank>=allDosesWater)
            {
                Console.WriteLine(allDosesWater);
            }
        }
    }
}
