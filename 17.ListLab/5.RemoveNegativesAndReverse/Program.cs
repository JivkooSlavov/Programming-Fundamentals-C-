namespace _5.RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumber = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> result = new List<int>();

            for (int i = 0; i < listOfNumber.Count; i++)
            {
                if (listOfNumber[i]>=0)
                {
                    result.Add(listOfNumber[i]);
                }
            }
            if (result.Count==0)
            {
                Console.WriteLine("empty");
                return;
            }
            result.Reverse();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}