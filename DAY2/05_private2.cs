using static System.Console;

class Bike
{
    private int gear = 0;

    public void SetGear(int g)
    {
        gear = g; 
    }
}

class Program
{
    public static void Main()
    {
        Bike b = new Bike();

//      b.gear = -10; // error
        b.SetGear(-10); // ok
    }
}


