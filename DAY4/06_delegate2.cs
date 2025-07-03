using System;
using static System.Console;

// 핵심 #1. delegate 만드는 법 정확히 알아야 합니다.
// => delegate1.cs 주석을 반드시 외우세요

// 핵심 #2. 원리

delegate void MyFunc(int arg);

/*
// => 위 한줄을 보고 컴파일러가 아래 처럼 변경합니다.
// => "MyFunc" 라는 이름의 클래스 생성
class MyFunc : MulticastDelegate
{
    // 함수(반환타입 void, 인자 int한개인) 주소등을 저장했다가 호출할수 있도록하는
    // 복잡한 코드 생성
}
*/





class Program
{
    public static void Main()
    {

        // MyFunc 는 결국 클래스로 만든 타입입니다.
        // => C# 에서 모든 타입의 객체는 "new" 로 만들어야 합니다.
        // => 그래서 아래 코드가 정확한 코드
        MyFunc f1 = new MyFunc(Foo);
        f1(10);


        // delegate 는 편의 표기법을 제공하기 때문에
        // 아래 처럼 사용가능합니다.
        // 함수는 signature가 동일한 함수만 등록가능
        // => signature(함수 리턴타입과 인자 타입, 갯수)
        MyFunc f = Foo; 

        f(10); 

    }


    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}
