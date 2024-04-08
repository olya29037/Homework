using System;
namespace Lesson1_3;

public class Task1
{
	public static void Five()
	{
        Console.WriteLine("Введите число:");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int number))
        {
            if (number > 5 && number < 10)
            {
                Console.WriteLine("Число больше 5 и меньше 10");
            }
            else
            {
                Console.WriteLine("Неизвестное число");
            }
        }
        else
        {
            Console.WriteLine("Ошибка ввода. Введите целое число.");
        }
    }
}

