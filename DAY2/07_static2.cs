using static System.Console;

// 방법 #2. static field

class Car
{
    private int speed = 0;
    private int color = 10; // instance field

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
        // Car 객체가 한개도 없어도
        // static field 는 메모리에 놓이게 됩니다.
        // public 에 있다면 "Car.cnt" 이름으로 언제라도 접근 가능
        Console.WriteLine($"{Car.cnt}"); // 0

        Car c1 = new Car(50);
        Car c2 = new Car(80);

        Console.WriteLine($"{Car.cnt}"); // 2

    }
}

// 핵심
// instance field : 객체 각각의 대한 특징을 나타내는 데이타
//                  => 자동차의 속도(speed) 는 각각의 자동차가 다르다.

// static field : 타입 자체에 대한 특징. 동일 타입의 모든 객체가 공유
//                  => 자동차의 갯수등
