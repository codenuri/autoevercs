int add1(int a, int b)
{
    return a + b;
}

// 구현부가 간단한(1줄) 함수는 아래 처럼 만들어도 됩니다.
// 함수() 뒤에 "=> 반환값" 으로 표현
// "expression bodied" 라는 문법
// 다른 언어에서 볼수 없는 C# 만의 특징
// 아주 널리 사용됩니다.
int add2(int a, int b) => a + b;

void sayHello() => Console.WriteLine("Hello");

Console.WriteLine( add1(3, 4) );

sayHello();