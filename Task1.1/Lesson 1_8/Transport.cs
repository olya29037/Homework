using System;
namespace Lesson_1_8
{
    public class Transport
    {

        public virtual void Move()
        {
            Console.WriteLine($"Transport is moving");
        }
        public virtual void Park()
        {
            Console.WriteLine($"Transport is parking");
        }
        
    }

}

