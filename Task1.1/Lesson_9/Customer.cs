using System;
namespace Lesson_9
{
    class Customer : Person
    {
        public string Address { get; set; }
        public int BirthYear { get; set; }

        public override int GetYear()
        {
            return BirthYear;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"Birth Year: {BirthYear}");
        }
    }
}

