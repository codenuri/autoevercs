using System.Diagnostics.SymbolStore;
using static System.Console;

delegate void MyFunc(int arg);

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // 자신의 static method 인 SMethod 등록
        MyFunc f1 = Program.SMethod; // ok
        MyFunc f2 = SMethod;

        // 인스턴스 메소드 등록은 "객체"가 필요
        // 현재 Main()안에서는 객체(this)가 없다
        //MyFunc f3 = IMethod; // error. Main 인자는 this 가 없다
                             // 그래서 자동 추가될수도 없다

        Program pg = new Program();
        MyFunc f3 = pg.IMethod;

        pg.Foo(); // Foo(pg)
    }

    public void Foo() // void Foo(Program this)
    {
        MyFunc f4 = IMethod; // ok.. 아래 코드로 변경됨
        MyFunc f5 = this.IMethod; // ok
    }
}
