using System.Text;

namespace MidtermTest;

class Program   //Это решение Task4
{
    static void Main()
    {
        Console.WriteLine("Введите день недели:");
        string userInput = Console.ReadLine();

        if (Enum.TryParse(userInput, true, out DaysOfWeek day))
        {
            switch (day)
            {
                case DaysOfWeek.Суббота:
                case DaysOfWeek.Воскресенье:
                    Console.WriteLine("Это выходной день.");
                    break;
                default:
                    Console.WriteLine("Это рабочий день.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Некорректный ввод.");
        }
    }
}

class Program// Это решение Task5
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello, World!");
        Console.WriteLine(sb.ToUpperString());
    }
}


