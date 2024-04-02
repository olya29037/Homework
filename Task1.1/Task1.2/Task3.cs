namespace Lesson_1.Homework
{
    public static class Task3
    {
        public static void WriteOut()
        {
            int x = -20;
            do
            {
                Console.WriteLine(x);
                x -= 20;
            } while (x >= -1000);
        }
    }
}
