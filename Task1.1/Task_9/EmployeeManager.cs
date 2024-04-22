
namespace Lesson_10
{
    public class EmployeeManager : IPersonManagement<Employee>
    {
        public List<Employee> employees = new List<Employee>();

        public void DisplayPerson (Employee person)
        {
            Console.WriteLine(person.Id);
            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
            Console.WriteLine(person.Position);
            Console.WriteLine(person.Salary);
        }

        public List<Employee> GetAll()
        {
            foreach (Employee employee in employees)
            {
                DisplayPerson(employee);
            }

            return employees;
        }
    }
}
