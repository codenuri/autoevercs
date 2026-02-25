using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // 자신의 static method 호출하기
        // static method   : 타입이름.메소드이름()
        // instance method : 객체이름.메소드이름()

        Program.SMethod(1); // ok
        SMethod(1);         // 자신의 static 메소드 인경우, 타입이름생략가능

        // 인스턴스 메소드를 호출하려면 객체가 필요하다
        Program pg = new Program();
        pg.IMethod(1);

        pg.Foo();   // Foo(pg)
    }

	public void Foo() // void Foo(Program this)
	{
        // 여기서 instance method 호출
        this.IMethod(1);  // 정확한 표기 "객체.인스턴스메소드()"
        IMethod(1);       // this 생략 가능

        // static method 는 타입이름으로 
        Program.SMethod(1);
        SMethod(1);
    }
}
