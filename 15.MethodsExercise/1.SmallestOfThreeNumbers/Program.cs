namespace _1.SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int three = int.Parse(Console.ReadLine());
            int minnumber = int.MaxValue;
            minnumber = MethodMinNumber(one, two, three, minnumber);
        }

        static int MethodMinNumber(int one, int two, int three, int minnumber)
        {
            if (one <= minnumber)
            {
                minnumber = one;
            }
            if (two <= minnumber)
            {
                minnumber = two;
            }
            if (three <= minnumber)
            {
                minnumber = three;
            }
            Console.WriteLine(minnumber);
            return minnumber;
        }
    }
}