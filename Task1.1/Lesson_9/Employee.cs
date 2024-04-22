using System;
namespace Lesson_9
{
    class Employee : Person
    {
        public string Position { get; set; }
        public int Experience { get; set; }
        public int Year { get; set; }

        public override int GetYear()
        {
            return Year;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Position: {Position}");
            Console.WriteLine($"Experience: {Experience} years");
            Console.WriteLine($"Year started working: {GetYear()}");
        }
    }
}

