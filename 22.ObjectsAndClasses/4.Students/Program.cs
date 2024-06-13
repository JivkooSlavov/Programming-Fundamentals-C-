using System.ComponentModel;

namespace _4.Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            List<Student> students = new List<Student>();
            while ((input=Console.ReadLine()) != "end")
            {
                string[] infoArray = input.Split();
                string firstName = infoArray[0];
                string lastName = infoArray[1];
                int age = int.Parse(infoArray[2]);
                string homeTown = infoArray[3];
                bool studentExist = false;
                foreach (var student in students)
                {
                    if (student.FirstName== firstName&&student.LastName==lastName)
                    {
                        student.Age = age;
                        student.HomeTown = homeTown;
                        studentExist = true;
                        break;
                    }
                }
                if (!studentExist)
                {
                    Student student = new Student()
                    {
                        FirstName = firstName,
                        LastName = lastName,
                        Age = age,
                        HomeTown = homeTown
                    };
                    students.Add(student);
                }


            }
            string town = Console.ReadLine();
            foreach (Student currentStudent in students)
            {
                if (currentStudent.HomeTown == town)
                {
                    Console.WriteLine($"{currentStudent.FirstName} {currentStudent.LastName} is {currentStudent.Age} years old.");
                }
            }
        }
        class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
            public string HomeTown { get; set; }
        }
                    
    }

}