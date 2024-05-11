using System;

internal class Program
{
    static void Main()
    { 
        string intput=Console.ReadLine();
        while (intput != "END")
        {
            bool isNumberPalindrome = IsNumberPalindrome(intput);
            Console.WriteLine(isNumberPalindrome);
            intput = Console.ReadLine();
        }

    }

    static bool IsNumberPalindrome(string symbols)
    {
        int left = 0;
        int right = symbols.Length - 1;
        while (left < right)
        {
            if (symbols[left] != symbols[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

}