
namespace Lesson_1.Homework
{
    public class Task4
    {
        public static void Symbols()
        {
            Console.WriteLine("Введите символ (W, S, A, D):");
            ConsoleKeyInfo key = Console.ReadKey();

            Console.WriteLine();

            if (key.Key == ConsoleKey.W)
            {
                Console.WriteLine("Переместить фигуру вверх");
            }
            else if (key.Key == ConsoleKey.S)
            {
                Console.WriteLine("Переместить фигуру вниз");
            }
            else if (key.Key == ConsoleKey.A)
            {
                Console.WriteLine("Переместить фигуру влево");
            }
            else if (key.Key == ConsoleKey.D)
            {
                Console.WriteLine("Переместить фигуру вправо");
            }
            else
            {
                Console.WriteLine("Необходимости в перемещении нет");
            }
        }
    }
}
