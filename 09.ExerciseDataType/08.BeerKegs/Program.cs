using System;

namespace _08.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string name = "";
            float calculated = 0;

            for (int i = 0; i < number; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());
                float volume = (float)Math.PI * (radius * radius) * height;
                if (volume>calculated)
                {
                    calculated = volume;
                    name = model;
                }

            }
            Console.WriteLine(name);

        }
    }
}
