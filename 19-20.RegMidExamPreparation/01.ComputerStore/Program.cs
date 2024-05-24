using System.Diagnostics;

namespace _0._1ComputerStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string priceOFParts;
            double totalPrice = 0;
            double taxeOfTotaPrice = 0;
            double specialPrice = 0;
            double regularPrice = 0;
            bool inValid = false;
            while (true)
            {
                priceOFParts = Console.ReadLine();
                if (priceOFParts=="special" || priceOFParts =="regular")
                {
                    break;
                }
                double price = double.Parse(priceOFParts);
                if (price>=0)
                {
                    totalPrice += price;
                }
                else if (price<0)
                {
                    Console.WriteLine("Invalid price!");
                }
            }
            if (totalPrice<=0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }
            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {totalPrice:f2}$");
            taxeOfTotaPrice = totalPrice * 0.2;
            Console.WriteLine($"Taxes: {taxeOfTotaPrice:f2}$");
            Console.WriteLine("-----------");
            if (priceOFParts == "special")
            {
                specialPrice = (totalPrice+taxeOfTotaPrice) * 0.9;
                Console.WriteLine($"Total price: {specialPrice:f2}$");
            }
            else
            {
                regularPrice = totalPrice +taxeOfTotaPrice;
                Console.WriteLine($"Total price: {regularPrice:f2}$");
            }
        }
    }
}