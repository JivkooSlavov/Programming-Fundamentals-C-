namespace _3.MergingLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> first = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> second = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
            List<int> lastList = new List<int> ();
            int interaction = Math.Max(first.Count, second.Count); 
            for (int i = 0; i < interaction; i++)
            {
                if (i<first.Count)
                {
                    lastList.Add(first[i]);
                }
                if (i<second.Count)
                {
                    lastList.Add(second[i]);

                }

            }
            Console.WriteLine(string.Join(" ",lastList));
        }
    }
}