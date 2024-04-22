using Lesson_9;

class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee()
        {
            Position = "Game Designer",
            Experience = 5,
            Year = 2019
        };

        Customer cust = new Customer()
        {
            Address = "Glukhova St 30",
            BirthYear = 1997
        };

        Console.WriteLine("Employee Information:");
        emp.PrintInfo();

        Console.WriteLine("\nCustomer Information:");
        cust.PrintInfo();
    }
}