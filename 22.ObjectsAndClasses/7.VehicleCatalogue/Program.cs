using System.Reflection;

namespace _7.VehicleCatalogue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();
            string command = "";
            while ((command=Console.ReadLine())!="end")
            {
                string[] array = command.Split("/");
                string type = array[0];
                string brand = array[1];
                string model = array[2];
                int value = int.Parse(array[3]);

                if (type == "Car")
                {
                    Car car = new Car();
                    car.Brand = brand;
                    car.Model = model;
                    car.HorsePower  = value;
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck();
                    truck.Brand = brand;
                    truck.Model = model;
                    truck.Weight = value;
                    trucks.Add(truck);

                }

            }
            Console.WriteLine("Cars:");
            foreach (var car in cars.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }
            Console.WriteLine("Trucks:");
            foreach (var truck in trucks.OrderBy(x=>x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }


        class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HorsePower { get; set; }
        }
        class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Weight { get; set; }
        }
    }
}