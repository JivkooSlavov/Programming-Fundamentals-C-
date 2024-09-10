namespace _8.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] codes = Console.ReadLine().Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries);
            decimal total = 0;

            foreach (string code in codes)
            {
                char letterBefore = code[0];
                char letterAfter = code[code.Length - 1];
                decimal number = decimal.Parse(code.Substring(1, code.Length - 2));


                decimal position = 0;
                decimal result = 0;

                if (char.IsUpper(letterBefore))
                {
                    position = letterBefore - 'A' + 1;
                    result = number / position;
                }
                else if (char.IsLower(letterBefore))
                {
                    position = letterBefore - 'a' + 1;
                    result = number*position;

                }
                if (char.IsUpper(letterAfter))
                {
                    position = letterAfter - 'A' + 1;
                    result -= position;
                }
                else if (char.IsLower(letterAfter))
                {
                    position = letterAfter - 'a' + 1;
                    result += position;
                }
                total += result;
            }
            Console.WriteLine($"{total:f2}");
        }
    }
}