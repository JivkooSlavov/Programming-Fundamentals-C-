namespace _2.TheLift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int capacityOfWagon = 4;

            for (int i = 0; i < wagons.Length; i++)
            {
                int currentWagons = wagons[i];
                if (currentWagons<4)
                {
                    int emptySpaces = capacityOfWagon - currentWagons;
                    numberOfPeople -= emptySpaces;
                    if (numberOfPeople<0)
                    {
                        wagons[i] = capacityOfWagon - Math.Abs(numberOfPeople);
                        Console.WriteLine("The lift has empty spots!");
                        Console.WriteLine(string.Join(" ", wagons));
                        return;
                    }
                    wagons[i] = 4;
                }
            }
            if (numberOfPeople != 0)
            {
                Console.WriteLine($"There isn't enough space! {numberOfPeople} people in a queue!");
                Console.WriteLine(string.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine(string.Join(" ", wagons));
            }
        }
    }
}