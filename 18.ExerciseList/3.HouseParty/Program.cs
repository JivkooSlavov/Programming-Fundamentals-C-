namespace _3.HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalGuests = int.Parse(Console.ReadLine());
            List<string> guests = new List<string>();
            for (int i = 0; i < totalGuests; i++)
            {
                string[] arguments = Console.ReadLine().Split();
                string name = arguments[0];
                if (arguments[2]=="going!")
                {
                    if (guests.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        guests.Add(name);
                    }
                }
                else if (arguments[2]=="not")
                {
                    if (guests.Contains(name))
                    {
                        guests.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }
            Console.WriteLine(string.Join("\n", guests));
        }
    }
}