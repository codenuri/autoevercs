// 핵심
// static method 에서는 "static field" 만 접근가능
// instance method 에서는 "static field, instance field" 만 모두 접근가능

// 따라서
// Car c = new Car(30);
// int n = c.GetSpeed(); 에서 GetSpeed는 speed 필드에 접근해야 합니다.
//                       따라서, 

class Example
{
    private int data1 = 0;
    private static int data2 = 0;

    // 아래 코드에서 에러를 모두 고르세요
    // 힌트 1 : static field 는 객체가 없어도 메모리에 있다.
    // 힌트 2 : static method 는 객체 없이 호출한다.
    public void M1()
    {
        data1 = 0; // 1. ok
        data2 = 0; // 2. ok
    }
    public static void M2()
    {
        data1 = 0; // 3. error. data1 은 객체가 있어야 메모리 존재
        data2 = 0; // 4. ok. 객체가 없어도 data2 는 메모리에 존재

    }
}
class Program
{
    public static Main()
    {
        Example.M2(); // 객체 없이 호출. 

        Example e = new Example();
        e.M1();
    }
}