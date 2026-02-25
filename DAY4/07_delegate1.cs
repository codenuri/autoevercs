using System;
using static System.Console;

// delegate 문법 : 다른 언어에는 없는 C# 만의 특징


class Program
{
    public static void Main()
    {
        // ? 채워 보세요
        int n = 3;          // 정수 3를 보관하는 타입은 int
        string s = "ABCD";  // 문자열 "ABCD" 보관하는 타입은 string

        ? f = Foo;        // 메소드(의 호출정보, 함수 주소)를 보관하는 타입이 필요
                        // (C 언어의 함수 포인터 개념)
                        // 이 개념이 C# 의 delegate
    }

    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}
