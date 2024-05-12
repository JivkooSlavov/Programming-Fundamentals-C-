using System;
using System.Linq;

class Program
{
    static int[] ExchangeArray(int[] arr, int index)
    {
        if (index >= arr.Length || index < 0)
        {
            // Check if the index is within the valid range
            Console.WriteLine("Invalid index");
            return arr;
        }

        // Split the array into two sub-arrays
        int[] subArray1 = arr.Take(index + 1).ToArray();
        int[] subArray2 = arr.Skip(index + 1).ToArray();

        // Exchange the places of the two sub-arrays
        int[] result = subArray2.Concat(subArray1).ToArray();

        return result;
    }

    static void Main(string[] args)
    {
        int[] originalArray = { 1, 2, 3, 4, 5 };
        int indexToExchange = 3;
        int[] resultArray = ExchangeArray(originalArray, indexToExchange);

        Console.WriteLine(string.Join(", ", resultArray));
    }
}