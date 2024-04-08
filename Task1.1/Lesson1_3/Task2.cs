using System;
namespace Lesson1_3
{
    public class Task2
    {
        public static void Even()
        {
            Console.WriteLine("Введите число:");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine("Число четное");
                }
                else
                {
                    Console.WriteLine("Число нечетное");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Введите целое число.");
            }
        }
    }

}
