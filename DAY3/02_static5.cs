using static System.Console;


class Car
{
    private int speed = 0;
    private static int cnt = 0;

    public Car(int s)
    {
        speed = s;
        ++cnt;
    }

    public int GetCount() { return cnt; }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car(50);
        Car c2 = new Car(80);

        WriteLine($"{c1.GetCount()}");

    }
}


