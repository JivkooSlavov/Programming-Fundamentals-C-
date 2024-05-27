using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace _02.ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] shots = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int counter = 0;
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);
                if ((index < 0 || index >= shots.Length))
                {
                    continue;
                }

                int value = shots[index];

                if (shots[index]==-1)
                {
                    continue;
                }

                shots[index] = -1;
                counter++;
                for (int i = 0; i < shots.Length; i++)
                {
                    if (shots[i] == -1)
                    {
                        continue;
                    }
                    else if (shots[i] > value)
                    {

                        shots[i] -= value;
                    }
                    else if (shots[i] <= value)
                    {
                        shots[i] += value;
                    }
                }

            }
            Console.Write($"Shot targets: {counter} -> ");
            Console.Write(string.Join(" ", shots));
        }
    }
}