using System.Collections.Generic;

namespace _2.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ");
            string first = names[0];
            string second = names[1];
            int sum = 0;
            int length = Math.Max(first.Length, second.Length);
            for (int i = 0; i < length; i++)
            {
                if (i < first.Length && i < second.Length)
                {
                    sum += first[i] * second[i];
                }
                else if (i < first.Length)
                {
                    sum += first[i];
                }
                else if (i < second.Length)
                {
                    sum += second[i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
//namespace _2.CharacterMultiplier
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string[] names = Console.ReadLine().Split(" ");
//            int result = Sum(names[0], names[1]);
//            Console.WriteLine(result);
//        }

//        private static int Sum(string first, string second)
//        {
//            int sum = 0;
//            int length = Math.Max(first.Length, second.Length);
//            for (int i = 0; i < length; i++)
//            {
//                if (i < first.Length && i < second.Length)
//                {
//                    sum += first[i] * second[i];
//                }
//                else if (i < first.Length)
//                {
//                    sum += first[i];
//                }
//                else if (i < second.Length)
//                {
//                    sum += second[i];
//                }
//            }
//            return sum;
//        }
//    }
//}