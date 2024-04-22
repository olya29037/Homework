using System;
namespace Lesson_1_8
{
    public class Boat : Transport
    {

        public override void Move()
        {
            Console.WriteLine($"The boat is sailing");
        }

        public new void Park ()
        {
            Console.WriteLine($"The boat is mooring");
        }
    }
}


