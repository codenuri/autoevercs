using System;
using static System.Console;


delegate void MyFunc(int arg);

class Program
{
    public static void Main()
    {
        MyFunc f = Foo;

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
