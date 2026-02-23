using static System.Console;

// static 개념
// => 모든 (파이썬 포함) 객체지향 언어의 핵심!!! 
// => 반드시 이해해야 합니다.

// Car 객체(자동차)를 몇대나 만들었는지 알고 싶다

// 방법 #1. 모든 객체는 만들때 생성자가 호출된다.
// => cnt 라는 필드를 만들고
// => 생성자에서 ++ 하자

class Car 
{
    private int speed = 0;
    private int color = 10;

    public int cnt = 0;

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

        Console.WriteLine($"{c1.cnt}"); // ???

    }
}