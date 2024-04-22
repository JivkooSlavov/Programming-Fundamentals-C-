namespace _5.Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string purch = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            double price = 0;
            price = kindOfOrder(purch, price);
            double totalPrice = price * quantity;
            Console.WriteLine($"{totalPrice:f2}");
        }

        private static double kindOfOrder(string purch, double price)
        {
            if (purch == "coffee")
            {
                price = 1.50;
            }
            else if (purch == "water")
            {
                price = 1.00;
            }
            else if (purch == "coke")
            {
                price = 1.40;
            }
            else if (purch == "snacks")
            {
                price = 2.00;
            }

            return price;
        }
    }
}