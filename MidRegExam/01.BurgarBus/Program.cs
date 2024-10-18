namespace ExamFirstTask1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCities = int.Parse(Console.ReadLine());
            double totalProfitOfCities = 0;

            for (int i = 1; i <= numberOfCities; i++)
            {
                string nameOfCity = (Console.ReadLine());
                double income = double.Parse(Console.ReadLine());
                double expense = double.Parse(Console.ReadLine());
                double profit = income - expense;
                if (i%3 == 0) 
                {
                    profit = income - (expense * 1.5);
                }
                if (i%5  ==0)
                {
                    profit = (income * 0.9) - expense;
                }
                totalProfitOfCities += profit;
                Console.WriteLine($"In {nameOfCity} Burger Bus earned {profit:f2} leva.");
            }
            Console.WriteLine($"Burger Bus total profit: {totalProfitOfCities:f2} leva.");
        }
    }
}