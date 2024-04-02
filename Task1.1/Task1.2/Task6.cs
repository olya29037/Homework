namespace Lesson_1.Homework
{
    public static class Task6
    {
        public static void Birthday()
        {
            int number = 101;

            while (number < 800)
            {
                if (number % 29 == 0)
                {
                    Console.WriteLine(number);
                }
                number++;
            }
        }
    }
}

