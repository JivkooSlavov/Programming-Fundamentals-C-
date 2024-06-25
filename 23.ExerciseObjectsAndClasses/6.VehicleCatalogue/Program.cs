namespace _6.VehicleCatalogue
{
    class Vehicle
    {
        public string Type { get; set; }
        public string Model {  get; set; }
        public string Color {  get; set; }
        public double HorsePower {  get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> catalogue = new List<Vehicle>();
            string command = "";

            while ((command=Console.ReadLine())!="End")   
            {

                string[] truckArray = command.Split();
                string Type = truckArray[0];
                string Model = truckArray[1];
                string Color = truckArray[2];
                double HorsePower = double.Parse(truckArray[3]);


            }
        }
    }
}