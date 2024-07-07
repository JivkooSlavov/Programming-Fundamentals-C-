namespace _6.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {   Dictionary<string, Student> students = new Dictionary<string, Student>();
            int studentCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < studentCount; i++)
            {
                string studentName = Console.ReadLine();
                decimal grade = decimal.Parse(Console.ReadLine());
                if (!students.ContainsKey(studentName))
                {
                    Student student = new Student(studentName);
                    students.Add(studentName, student);
                }
                students[studentName].Grades.Add(grade);
            }
            var filteredStudents = students.Where(x => x.Value.Grades.Average() >= 4.50m);
            foreach (var student in filteredStudents)
            {
                Console.WriteLine(student.Value);
            }
        }
    }
    class Student
    {
        public string Name;
        public List<decimal> Grades;
        public Student(string name)
        {
            Name = name;
            Grades = new List<decimal>();
        }
        public override string ToString()
        {
            return $"{Name} -> {Grades.Average():f2}";
        }
    }

}