using Lesson_1_8;

class Program
{
    public static void Main()
    {
        Transport transport1 = new Boat();
        Transport transport2 = new Auto();

        var myAutoAuto = new Auto();
        var myBoatBoat = new Boat();

        transport1.Move();
        transport1.Park();
        Console.WriteLine();

        transport2.Move();
        transport2.Park();
        Console.WriteLine();

        myAutoAuto.Move();
        myAutoAuto.Park();
        Console.WriteLine();

        myBoatBoat.Move();
        myBoatBoat.Park();
        Console.WriteLine();

        Console.ReadLine();

    }
}
