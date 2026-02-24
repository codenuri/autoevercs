using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Animal();
        Dog    d = new Dog();

        Animal ad = d;

//      if (사용자입력 == 1) ad = a;

        // 핵심 : 아래 한줄은 어느 함수를 호출할까요 ?
        ad.Cry(); // ?
    }
}
// ad.Cry() 를 어떤 함수와 연결할것인가 ?
// => Function(Method) Binding 이라고 합니다. (104 page~)
// => 2개의 Binding 개념이 있습니다.

// 1. static binding : 컴파일 시간에 컴파일러가 어떤 함수를 호출할지 결정
//                    [핵심] 컴파일시간에는 대상체의 타입은 알수 없다
//               컴파일러가 알수 있는것은 ad 자체의 타입이 Animal 이라는 것
//               따라서, 컴파일러가 결정하면 실제 객체 타입이 아닌
//               Reference 타입으로 호출 "Animal Cry" 호출
// 빠르지만, 논리적이지 못하다(객체가 Dog 라도 Animal 호출)
// C++/C# 의 기본 바인딩 정책

// 2. dynamic binding : 컴파일 시간에는 "ad" 가리키는 메모리를 조사하는
//                      기계어(IL) 코드를 생성해 놓고
//                      실행시간에 메모리를 조사해서 호출을 결정
//                      대상체가 Dog 타입이 었다면 Dog Cry 호출
// 느리지만, 논리적이다
// Java, Python, Kotlin, Swift 등 대부분의 객체지향 언어의 기본 바인딩
// C++/C# 의 virtual method

