using System.ComponentModel.Design;

namespace _4.SoftUniParking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, User> users = new Dictionary<string, User>();
            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string operation = arguments[0];
                string userName = arguments[1];

                if (operation == "register")
                {
                    string licensePlate = arguments[2];
                    User newUser = new User(userName, licensePlate);
                    if (users.ContainsKey(userName))
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlate}");
                    }
                    else
                    {
                        users.Add(userName, newUser);
                        Console.WriteLine($"{userName} registered {licensePlate} successfully");
                    }
                }
                else if (operation == "unregister")
                {
                    if (users.ContainsKey(userName))
                    {
                        users.Remove(userName);
                        Console.WriteLine($"{userName} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {userName} not found");
                    }
                }
 
            }
            foreach (var item in users)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
    class User
    {
        public User(string userName, string licensePlate)
        {
            UserName = userName;
            LicensePlate = licensePlate;
        }

        public string UserName { get; set; }
        public string LicensePlate { get; set; }


        public override string ToString()
        {
            return $"{UserName} => {LicensePlate}";
        }
    }
}
