using static System.Console;

// static 개념
// => 모든 (파이썬 포함) 객체지향 언어의 핵심!!! 
// => 반드시 이해해야 합니다.

// Car 객체(자동차)를 몇대나 만들었는지 알고 싶다


class Car 
{
    private int speed = 0;
    private int color = 10;

    public Car(int s)
    {
        speed = s;
    }
}

class Program
{
    public static void Main()
    {
        Car c1 = new Car(50);
        Car c2 = new Car(80);

    }
}