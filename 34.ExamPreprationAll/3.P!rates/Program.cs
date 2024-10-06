namespace _3.P_rates
{
    class City
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public int Gold { get; set; }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<City> cities = new List<City>();
                string line = "";
                while ((line = Console.ReadLine()) != "Sail")
                {
                    string[] separate = line.Split("||");
                    string cityName = separate[0];
                    int population = int.Parse(separate[1]);
                    int gold = int.Parse(separate[2]);
                    City city = cities.FirstOrDefault(x => x.Name == cityName);
                    if (city != null)
                    {
                        city.Population += population;
                        city.Gold += gold;
                    }
                    else
                    {
                        city = new City();
                        city.Name = cityName;
                        city.Population = population;
                        city.Gold = gold;
                        cities.Add(city);

                    }
                }
                line = string.Empty;
                while ((line = Console.ReadLine()) != "End")
                {
                    string[] separate = line.Split("=>");
                    string action = separate[0];
                    string cityName = separate[1];
                    City city = cities.FirstOrDefault(x => x.Name == cityName);
                    if (action == "Plunder")
                    {
                        int people = int.Parse(separate[2]);
                        int gold = int.Parse(separate[3]);
                        city.Population -= people;
                        city.Gold-=gold;
                        Console.WriteLine($"{cityName} plundered! {gold} gold stolen, {people} citizens killed.");
                        if (city.Population ==0 || city.Gold ==0)
                        {
                            Console.WriteLine($"{city.Name} has been wiped off the map!");
                            cities.Remove(city);
                        }
                    }
                    else if (action == "Prosper")
                    {
                        int gold = int.Parse(separate[2]);
                        if (gold < 0)
                        {
                            Console.WriteLine($"Gold added cannot be a negative number!");
                            continue;
                        }
                        city.Gold += gold;
                        Console.WriteLine($"{gold} gold added to the city treasury. {cityName} now has {city.Gold} gold.");
                    }
                }
                if (cities.Count == 0)
                {
                    Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
                    return;
                }
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (City city in cities)
                {
                    Console.WriteLine($"{city.Name} -> Population: {city.Population} citizens, Gold: {city.Gold} kg");
                }

            }
        }
    }
}