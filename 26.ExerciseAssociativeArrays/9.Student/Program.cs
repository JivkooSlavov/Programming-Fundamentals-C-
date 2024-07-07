namespace _9.Student
{
    internal class Program
    {
            static void Main(string[] args)
            {
                Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
                int studentCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < studentCount; i++)
                {
                    string studentName = Console.ReadLine();
                     double grade = double.Parse(Console.ReadLine());
                    if (!students.ContainsKey(studentName))
                    {
                    students[studentName] = new List<double>();
                    }
                    students[studentName].Add(grade);
                }
            Console.WriteLine(string.Join($"{Environment.NewLine}",students
                .Where(x => (x.Value.Sum() / x.Value.Count) >= 4.50)
                .Select(x => $"{x.Key} -> {x.Value.Sum() / x.Value.Count():f2}")));
        }
    }
}