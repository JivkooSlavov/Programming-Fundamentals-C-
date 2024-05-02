namespace _10.MultiplyEvensByOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            numbers=Math.Abs(numbers);
            int sumOdd = 0;
            int sumEven = 0;

            while (numbers > 0) 
            {
                int currentNumber = numbers % 10;
                if (currentNumber % 2 == 0)
                {
                    sumEven += currentNumber;
                }
                else if (currentNumber %2!=0)
                {
                    sumOdd+= currentNumber;
                }
                numbers /= 10;
            }
            Console.WriteLine(sumEven*sumOdd);
        }
    }
}