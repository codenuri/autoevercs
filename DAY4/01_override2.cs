using static System.Console;

// 104 page ~ 

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
        Dog d = new Dog();

        Animal a = d;

//      if (사용자입력 == 1) a = new Animal();

        a.Cry(); // ?     
    }
}

// a.Cry() 를 어떤 메소드를 호출하게 할것인가 ? 어떤 메소드와 연결할것인가 ?
// => 함수 바인딩(function binding) 이라고 합니다

// 1. static binding : 컴파일 시간에 컴파일러가 어떤 함수와 연결할지 결정
// => 핵심 : 컴파일 시간에는 "a 자체의 타입"만 알고 a 가 가리키는 객체의 타입은 알수없다
// => 그래서 컴파일 시간에 결정하는 "a 자체의 타입"만 가지고 호출 결정
// => Animal Cry 호출됨.


// 2. dynamic binding : 실행시간에 결정됨
// => 컴파일 시간에는 "a" 가 가리키는 객체의 종류는 조사하는 코드가 생성되고
// => 실행할때, 조사하는 코드를 실행해서, 실제 어떤 객체가 메모리에 있는지 파악후 호출결정
// => Dog 객체가 있었다면 "Dog Cry" 호출

