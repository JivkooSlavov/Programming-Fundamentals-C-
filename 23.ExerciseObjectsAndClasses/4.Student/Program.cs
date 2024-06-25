namespace _4.Student
{   class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public double Grade { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

            int numberOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();
            for (int i = 0; i < numberOfStudents; i++)
            {

                string[] studentArray = Console.ReadLine().Split(" ").ToArray();

                Student student = new Student();
                student.FirstName = studentArray[0];
                student.LastName = studentArray[1];
                student.Grade = double.Parse(studentArray[2]);

                students.Add(student);

            }
            students = students.OrderByDescending(x=> x.Grade).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, students));
        }
    }
}