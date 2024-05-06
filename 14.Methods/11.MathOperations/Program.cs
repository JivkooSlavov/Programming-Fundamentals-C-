namespace _11.MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            string function = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());
            int result = AllResult(numberOne, function, numberTwo);
            Console.WriteLine(result);

        }

        static int AllResult(int numberOne, string function, int numberTwo)
        {
            int result = 0;
            if (function == "/")
            {
                result = numberOne / numberTwo;


            }
            else if (function == "*")
            {
                result = numberOne * numberTwo;
         

            }
            else if (function == "+")
            {
                result = numberOne + numberTwo;
      

            }
            else if (function == "-")
            {
                result = numberOne - numberTwo;
   

            }
            return result;
        }
    }
}