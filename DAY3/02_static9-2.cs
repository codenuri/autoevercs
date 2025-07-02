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
        pg.IMethod1();  // IMethod1(pg)
    }

    public static void SMethod() 
    {
        IMethod2(); // this.IMethod2() 가 될까 ?
                    // static 안에는 this가 없습니다. - static9-3 참고
    }

    // 아래 코드가 이 예제의 핵심 부분
    public void IMethod1()  // void Method1(Program this)
    {
        // static method 는 어디서도 호출가능
        Program.SMethod(); // ok
        SMethod();         // ok

        // instance method 는 객체 필요
        // 현재 메소드 안에서 "this" 는 나를 가리키는 객체참조
        this.IMethod2(); // ok
        IMethod2();      // ok. 이렇게 해도, 컴파일러가 this 추가
    }


    public void IMethod2()
    {

    }
}