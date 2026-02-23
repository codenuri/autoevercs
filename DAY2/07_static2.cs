using static System.Console;

// 방법 #2. static field

class Car
{
    private int speed = 0;
    private int color = 10;

//  public int cnt = 0; 
    public static int cnt = 0;  // static field
                                // 모든 객체가 공유하는 필드 만들때 사용
                                // 1. Car 객체가 한개도 없어도 메모리에 존재
                                //    (최초 프로그램 실행시 메모리 할당)
                                // 2. Car 객체 생성시, static field 는
                                //    객체 개별 메모리에 포함안됨
                                // 3. 프로그램에서 접근시는 "클래스이름.필드"
                                //    "Car.cnt"
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

        Console.WriteLine($"{Car.cnt}"); // ???

    }
}