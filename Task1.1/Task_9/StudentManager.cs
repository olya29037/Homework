using System;

namespace Lesson_10
{
    public class StudentManager : IPersonManagement<Student>
    {
       List<Student> students = new List<Student>();

        public void DisplayPerson(Student person)
        {
            Console.WriteLine(person.Id);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.CourseNumber);
            Console.WriteLine(person.AverageGrade);
        }

        public List<Student> GetAll()
        {
            foreach (Student student in students)
            {
                DisplayPerson(student);

            }
            return students;
        }
    }
}

