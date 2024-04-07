
namespace Lesson1._6
{
	public class Task2
	{
        public static void Double()
        {
            int[,] array = new int[,]
        {
            { 5, 3, 8 },
            { 2, 7, 1 },
            { 9, 4, 6 }
        };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                int max = array[i, 0];
                for (int j = 1; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
                Console.WriteLine("Значение максимального элемента ряда " + i + ": " + max);
            }
        }
    }
}

