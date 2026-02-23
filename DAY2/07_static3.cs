using static System.Console;

// 핵심 : static method

class Car
{
    private int speed = 0;
    private int color = 10; 

    private static int cnt = 0;   // 이제 외부에서 직접 접근 못함

//  public int GetCount() {  return cnt; }  // instance method
                                        // "객체.메소드()"로 호출
                                        // 반드시 객체가 있어야 호출가능

    public static int GetCount() { return cnt; }  // static method
                                        // 객체 없이 호출가능한 메소드
                                        // "클래스이름.메소드()"로 호출

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
        Console.WriteLine($"{Car.GetCount()}");

//        Car.cnt = 100;

        Car c1 = new Car(50);
        Car c2 = new Car(80);

        Console.WriteLine($"{Car.GetCount()}");  // 2

    }
}

