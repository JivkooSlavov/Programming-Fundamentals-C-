using System;

/*
1 2 3 4 4 5 5 5 6 7 8 9
0 1 2 3 4 5 6 7 8 9 10 11
*/
internal class Program
{
    static void Main()
    {
        string[] symbols = Console.ReadLine().Split();
        int bestCount = 0;
        string bestCountSymbol = "";

        for (int i = symbols.Length - 1; i >= 0; i--)
        {
            int count = 1;
            for (int j = i - 1; j >= 0; j--)
            {
                if (symbols[i] == symbols[j])
                {
                    count++;
                    if (bestCount <= count)
                    {
                        bestCount = count;
                        bestCountSymbol = symbols[i];
                    }
                }
                else
                {
                    break;
                }
            }
        }

        for (int i = 0; i < bestCount; i++)
        {
            Console.Write($"{bestCountSymbol} ");
        }
    }
}