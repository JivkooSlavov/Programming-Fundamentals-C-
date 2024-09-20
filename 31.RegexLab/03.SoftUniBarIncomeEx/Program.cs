using System.Net.Http.Headers;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Text.RegularExpressions;

namespace _03.SoftUniBarIncomeEx
{
    class Order
    {
        public string Customer { get; set; }
        public string Product { get; set; }
        public uint Count { get; set; }
        public decimal Price { get; set; }

        public decimal TotalPrice
        {
            get
            {
                return Count * Price;
            }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Order> listOfTotal = new List<Order>();
            string input = "";
            string pattern = @"\%(?<name>[A-Z][a-z]+)\%[^|$%.]*\<(?<product>\w+)\>[^|$%.]*\|(?<count>\d+)\|[^|$%.]*?(?<price>\d+(?:\.\d+)?)\$";
            decimal total = 0;
            while ((input = Console.ReadLine()) != "end of shift")
            {
                if (!Regex.IsMatch(input, pattern))
                {
                    continue;
                }
                Match match = Regex.Match(input, pattern);

                Order order = new Order();
                order.Customer = match.Groups["name"].Value;
                order.Product = match.Groups["product"].Value;
                order.Count = uint.Parse(match.Groups["count"].Value);
                order.Price = decimal.Parse(match.Groups["price"].Value);
                total += order.TotalPrice;
                listOfTotal.Add(order);

                Console.WriteLine($"{order.Customer}: {order.Product} - {order.TotalPrice:f2}");
            }
            Console.WriteLine($"Total income: {total:f2}");
        }
    }
}