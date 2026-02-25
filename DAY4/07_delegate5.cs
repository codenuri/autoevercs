using System;
using static System.Console;


delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        // Delegate 변수에는 여러개 함수 등록 가능합니다.
        MyFunc f = Foo;

        f += Goo;
        f += Foo; // 동일 함수를 2번 등록

        f(10); // Foo, Goo, Foo 호출(등록순)

        f -= Foo;

        f(10);

        f = Goo; // 기존에 등록된 모든 메소드 제거후 Goo 등록
        f(10);
    }


    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
    public static void Goo(int arg)
    {
        WriteLine($"Goo : {arg}");
    }
}
