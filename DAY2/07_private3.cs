using static System.Console;

class Bike
{
    private int gear = 0;

    public void SetGear(int value)
    {
        gear = value;
    }
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();
                
//        b.gear = -10;  // error. private 필드는 접근 안됨.
        b.SetGear(-10);  // ok
    }
}


