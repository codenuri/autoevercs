using System;
using static System.Console;
// delegate 만드는 법

// #1. 함수 모양을 그대로 복사 : void Foo(int arg)
// #2. 함수 이름만 원하는 이름으로 변경 : MyFunc
// #3. 반환 타입앞에 "delegate" 추가
delegate void MyFunc(int arg);

// 위 처럼 만들면 MyFunc 가 타입이름이 됩니다
// => int, Point, Rect 같은 타입이름


class Program
{
    public static void Main()
    {
       MyFunc f = Foo;

        // f 에는 Foo에 대한 호출 정보가 담겨 있습니다.
        // 핵심 정보 : Foo 메소드의 메모리 주소

        f(10);        // Foo(10) 의 의미
        f.Invoke(10); // 위와 동일
    }

    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}
