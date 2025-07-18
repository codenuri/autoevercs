using System;
using static System.Console;

// delegate 란 ?
// => 함수의 호출 정보(함수가 있는 메모리 주소등)을 보관했다가
// => 해당함수를 호출할때 사용
// => C 언어의 함수 포인터!


// delegate 만드는 법
// 1. 함수 선언만 복사
// 2. 앞에 delegate 추가
// 3. 함수 이름을 원하는 이름으로 변경

// 아래 코드에서 "MyFunc" 는 이제 타입입니다.
// => 함수의 호출 정보를 저장했다가 호출할때 사용
delegate void MyFunc(int arg);


class Program
{
    public static void Main()
    {
        // ? 타입을 채워 보세요

        int n = 3;          // 3을 보관해야 하므로 int
        string s = "ABCD";  // 문자열을 보관해야 하므로 string

        MyFunc f = Foo; // 메소드(함수)를 보관하기 위한 타입
                        // 주의 : 이렇게해야 Foo() 호출
                        //        Foo 는 메소드 이름

        f(10); // Foo(10)와 동일, 즉, 저장된 함수 호출

    }


    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}
