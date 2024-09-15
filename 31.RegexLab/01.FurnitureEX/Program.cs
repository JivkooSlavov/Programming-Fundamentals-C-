using System.Net.NetworkInformation;
using System.Text.RegularExpressions;

namespace _01.FurnitureEX
{
    class Furniture
    {
        public string Kind { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public decimal Total()
        {
            return Price * Count;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Furniture> furnitures = new List<Furniture>();

            string pattern = @">>(?<kind>[A-Za-z]+)<<(?<price>\d+\.\d+|\d+)!(?<count>\d+)";
            string command = "";
            while ((command = Console.ReadLine()) != "Purchase")
            {
                MatchCollection matches = Regex.Matches(command, pattern);
                foreach (Match match in matches)
                {
                    Furniture furniture = new Furniture();
                    furniture.Kind = match.Groups["kind"].Value;
                    furniture.Price = decimal.Parse(match.Groups["price"].Value);
                    furniture.Count = int.Parse(match.Groups["count"].Value);

                    furnitures.Add(furniture);
                }
            }
            decimal totalCost = 0;
            Console.WriteLine("Bought furniture:");
            foreach (var furniture in furnitures)
            {
                Console.WriteLine(furniture.Kind);
                totalCost += furniture.Total();
            }
            Console.WriteLine($"Total money spend: {totalCost:F2}");
        }
    }
}