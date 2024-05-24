using System.Xml.Schema;

namespace _1.BonusScoringSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int numberOfLectures = int.Parse(Console.ReadLine());
            int additionalBonus = int.Parse(Console.ReadLine());

            double maxBonus = 0;
            double student = 0;

            for (int i = 0; i < numberOfStudents; i++)
            {
                double attendances = double.Parse(Console.ReadLine());
                double totalBonus = (attendances / numberOfLectures) * (5 + additionalBonus);
                totalBonus = Math.Ceiling(totalBonus);
                if (totalBonus > maxBonus)
                {
                    maxBonus = totalBonus;
                }
                if (attendances > student)
                {
                    student = attendances;
                }
            }
            Console.WriteLine($"Max Bonus: {maxBonus}.");
            Console.WriteLine($"The student has attended {student} lectures.");
        }
    }
}