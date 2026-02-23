class Person1
{
    // 자동 구현 property : 값의 유효성 확인 없음
    public int Age { get; set; } = 0;
}
class Person2
{
    // public 필드 : 값의 유효성 확인 없음
    public int age = 0;
}

class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
        Person2 p2 = new Person2();

        p1.Age = 10;
        p2.age = 10;
    }
}
