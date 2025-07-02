using static System.Console;

// field
// instance field : 객체당 한개 생성
// static   field : 모든 객체 공유. 오직 한개 생성

// method
// instance method : 객체이름.메소드() 로 호출, 객체가 있어야 호출가능
// static   method : 클래스이름.메소드() 로 호출, 객체가 없어도 호출가능


class Car
{
    private int speed = 0;
    private static int cnt = 0;

    public Car(int s)
    {
        speed = s;
        ++cnt;
    }
    /*
    public int GetCount()   // instance method
    {                       // => "객체.메소드()" 로 호출
        return cnt;         // => "객체가 있어야만" 호출가능
    }
    */
    public static int GetCount() // static method 
    {                            // => "클래스이름.메소드()"로 호출
        return cnt;              // => 객체가 없어도 호출가능
    }                            // => static field는 객체가 없어도 존재 하므로
}                                //    여기에 접근하기 위해

class Program
{
    public static void Main()
    {
        // 여기서도 자동차 갯수를 구하고 싶다.??
        WriteLine($"{Car.GetCount()}");

        Car c1 = new Car(50);
        Car c2 = new Car(80);

        WriteLine($"{Car.GetCount()}");

    }
}


