using System;
namespace Lesson_1_8
{
    public class Auto : Transport
    {

        public new void Move()
        {
            base.Move();
            Console.WriteLine($"The auto is moving");
        }

        public override void Park()
        {
            Console.WriteLine($"The auto is parking");
        }
    }
}

