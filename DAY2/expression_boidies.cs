// expression_boidies.cs 

// expression boidies 문법
// => Foo 함수의 구현은 한줄입니다.
// => C#에서 구현이 한줄인 함수는 {} 없이 만들수 있습니다.

/*
int Foo()
{
    return 10;
}
*/

int Foo() => 10; // 위 Foo 함수와 완전히 동일


int n = Foo();

Console.WriteLine(n);


// 반환타입이 void 도 됩니다.
void Goo(int n) => Console.WriteLine(n);

Goo(10);

// 잘만들어진 C# 오픈소스들에서 위처럼 사용하는 코드가 아주 많습니다.