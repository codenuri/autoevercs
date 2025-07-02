using static System.Console;

// C전역변수 : 언제 어디서도 접근 가능합니다.
// static field : private 으로 만들면
//                Car 메소드만 접근 가능.(안전!!)

class Car
{
    private int speed = 0;

//    public static int cnt = 0;  
    private static int cnt = 0;

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
        Car c1 = new Car(50);
        Car c2 = new Car(80);

//      Car.cnt = -10; // 사용자가 실수 했다.
                       // 이렇게 할수 없게 해야 한다.
                       // static field 라도 보호해야 한다
                       // private 사용

//      WriteLine($"{Car.cnt}");
    }
}


