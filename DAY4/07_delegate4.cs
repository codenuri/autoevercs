using System;
using static System.Console;

// 아래 코드에는 클래스가 몇개 있을까요 ?

delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        MyFunc f = Foo;

        f(10);
        f.Invoke(10);
    }
    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}
