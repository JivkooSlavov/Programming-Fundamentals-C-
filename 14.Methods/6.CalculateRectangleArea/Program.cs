namespace _6.CalculateRectangleArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = CalculateArea(w, h);
            Console.WriteLine(area);
        }

        static double CalculateArea(double w, double h)
        {
            return w * h;
        }
    }
}