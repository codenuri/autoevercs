class Program
{
    public static void Main()
    {
        // #1. static method 는 객체가 없어도 호출가능
        // => 클래스 이름만 알면 호출가능
        // => "언제 어디서도 호출가능" 하다는것
        Program.SMethod();
        SMethod();      // 같은 클래스 메소드에서는 클래스 이름 생략가능

        // #2. instance method 는 객체 필요
        Program pg = new Program();
        pg.IMethod1();
    }

    public static void SMethod() { }

    public void IMethod1() 
    { 
    }

    public void IMethod2()
    {

    }
}