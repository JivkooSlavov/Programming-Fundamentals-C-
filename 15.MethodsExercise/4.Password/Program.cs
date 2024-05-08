namespace _04.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool lenghtCheckPass = MethodCheck(input);
            bool lettersAndDigitsPass = MethodLAD(input);
            bool digits2Pass = MethodDigits(input);

            if (!lenghtCheckPass)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!lettersAndDigitsPass)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!digits2Pass)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (lenghtCheckPass && lettersAndDigitsPass && digits2Pass)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool MethodLAD(string input)
        {
            foreach (var symbol in input)
            {
                if (symbol >= 65 && symbol <= 90 || symbol >= 97 && symbol <= 122 || symbol >= 48 && symbol <= 57)
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool MethodDigits(string input)
        {
            int counter = 0;
            foreach (char c in input)
            {
                if (c >= 48 && c <= 57)
                {
                    counter++;
                }

            }
            if (counter < 2)
            {
               return false;
            }

            return true;
        }

        private static bool MethodCheck(string input)
        {
            if (input.Length < 6 || input.Length > 10)
            {
                return false;
            }

            return true;
        }
    }
}