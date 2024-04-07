
namespace Lesson1._6;

public static class Task1
{
    public static void Massive()
    {
        int[] array = new int[6];

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Введите число: ");
            if (!int.TryParse(Console.ReadLine(), out array[i]))
            {
                Console.WriteLine("Ошибка ввода. Пожалуйста, введите целое число.");
                i--;
            }
        }

        Array.Sort(array);
        Array.Reverse(array);

        Console.WriteLine("Отсортированные по убыванию числа:");
        foreach (int element in array)
        {
            Console.WriteLine(element);
        }
    }
}