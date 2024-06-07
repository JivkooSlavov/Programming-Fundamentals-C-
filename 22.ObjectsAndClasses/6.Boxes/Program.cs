using System.Data;

namespace _6.Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = "";
            List<Box> boxes = new List<Box>();
            while ((command=Console.ReadLine())!="end")
            {
                string[] array = command.Split();
                int serialNumber = int.Parse(array[0]);
                string itemName = array[1];
                int quantity = int.Parse(array[2]);
                double price = double.Parse(array[3]);

                Item item = new Item()
                {
                    Name = itemName,
                    Price = price
                };
                Box box = new Box()
                {
                    SerialNumber=serialNumber,
                    Item = item,
                    ItemQuantity = quantity,
                    Price = price*quantity,
                };
                boxes.Add(box);

            }
            foreach (var box in boxes.OrderByDescending(x=>x.Price))
            {
                Console.WriteLine(box.SerialNumber);
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.Price:f2}");
            }; 
        }
        class Item
        {
            public string Name { get; set; }
            public double Price { get; set; }
        }
        class Box
        { 
            public int SerialNumber { get; set; }
            public Item Item {  get; set; }
            public int ItemQuantity { get; set; }
            public double Price { get;set; }    
        }
    }
}