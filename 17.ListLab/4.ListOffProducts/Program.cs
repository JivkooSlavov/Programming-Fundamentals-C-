namespace _4.ListOffProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int list = int.Parse(Console.ReadLine());
            List<string> products = new List<string>();
            for (int i = 0; i < list; i++)
            {
                string nameOfProduct = Console.ReadLine();
                products.Add(nameOfProduct);
               

            }
            products.Sort();
            for (int i = 0;i < products.Count;i++) 
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}