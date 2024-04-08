using System.Threading.Tasks.Dataflow;

namespace _01.Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] wagons = new int[n];
            int peopleSum = 0;
            for (int i = 0; i < wagons.Length; i++)
            {
                int people = int.Parse(Console.ReadLine());
                wagons[i] = people; 
                peopleSum += people;
            }
            Console.WriteLine(string.Join(" ", wagons));
            Console.WriteLine(peopleSum);
        }
    }
}