using System;
namespace Lesson1_3
{
	public class Task3
	{
		public static void Operations()
		{
            Console.WriteLine("Введите номер операции (1,2,3):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int number))
            {
                if (number == 1)
                {
                    Console.WriteLine("Операция умножения");
                }
                else if (number ==2)
                {
                    Console.WriteLine("Операция деления");
                }
                else if (number ==3)
                {
                    Console.WriteLine("Операция деления по модулю");
                }
            }
            else
            {
                Console.WriteLine("Ошибка ввода. Операция не определена");
            }
        }
    }

}

