// 다음 코드에서 에러를 모두 찾으세요
class Car
{
    // instance field : Car 객체를 생성해야먄 메모리에 존재하게 된다.
    // static   field : 객체가 없어도 메모리에 존재하고, 모든 객체가 공유
    private int speed = 0;
    private static int cnt = 0;

    // static method : 객체 없이 호출 가능
    // Car.F1() 객체 없이 호출
    public static void F1()
    {
        speed = 10; // 1. error. static method 는 instance field 만 접근 안됨
        cnt = 10;   // 2. ok     static method 는 static   field 만 접근 안됨
    }
    // F2() 메소드를 호출하려면 반드시 객체가 있어야 한다
    // Car c = new Car();
    // c.F2(); // 이순간은 speed, cnt 모두 존재
    public void F2()
    {
        speed = 10; // 3. ok
        cnt = 10;   // 4. ok
    }
}
class Program
{
    public static void Main()
    {
        Car.F1();
    }
}