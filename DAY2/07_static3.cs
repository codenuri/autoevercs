using static System.Console;

// 핵심 : static method

class Car
{
    private int speed = 0;
    private int color = 10; 

    private static int cnt = 0;   // 이제 외부에서 직접 접근 못함

    public int GetCount() {  return cnt; } 


    public Car(int s)
    {
        speed = s;
        ++cnt;
    }
}

class Program
{
    public static void Main()
    {
        Console.WriteLine($"{Car.cnt}");

//        Car.cnt = 100;

        Car c1 = new Car(50);
        Car c2 = new Car(80);

        Console.WriteLine($"{Car.cnt}"); 

    }
}

