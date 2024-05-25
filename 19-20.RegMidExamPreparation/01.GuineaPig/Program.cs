namespace _1.GuineaPig
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double foodForPig = double.Parse(Console.ReadLine())*1000;  
            double hayForPig = double.Parse(Console.ReadLine())* 1000;  
            double coverForPig = double.Parse(Console.ReadLine())*1000;  
            double weightOfPig = double.Parse(Console.ReadLine()) * 1000;

            for (int i = 1; i <= 30; i++)
            {
                foodForPig -= 300;
                if (i % 2 == 0)
                {
                    double neededHay = foodForPig * 0.05;
                    hayForPig -= neededHay;
                }
                if (i % 3 == 0)
                {
                    double percentageOfWeight = (weightOfPig / 3);
                    coverForPig -= percentageOfWeight;
                }
                if (foodForPig < 0 || hayForPig < 0 || coverForPig < 0)
                {
                    Console.WriteLine("Merry must go to the pet store!");
                    return;
                }
            }

                Console.WriteLine($"Everything is fine! Puppy is happy! Food: {(foodForPig/1000):f2}, Hay: {(hayForPig/1000):f2}, Cover: {(coverForPig/1000):f2}.");
        }
    }
}