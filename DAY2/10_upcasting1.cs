// upcasting 개념 : 객체지향 언어에서 가장 중요한 개념중 하나!!
class Animal
{
    public int Age { set; get; } = 0;
}

class Dog : Animal
{
    public int Color { set; get; } = 0;
}

class Cat : Animal
{
    public int Speed { set; get; } = 0;
}

class Program
{
    public static void Main()
    {
        Dog r1 = new Dog(); // ok

//      int r2 = new Dog(); // error.

        // 핵심 #1. 기반 클래스 타입의 Reference 로
        //          파생 클래스 객체를 가리킬수 있다
        // => 가능한 이유는 "메모리 그림" 참고
        // => 왜 이렇게 하는지는 나중에 예제에서. 
        Animal r3 = new Dog(); // ?

        // 핵심 #2. 컴파일러는 컴파일 시간에 r3 가 가리키는 곳에 있는 객체의 
        //          정확한 타입은 알수 없습니다.
        // => 단지, Reference 의 자체의 타입(Animal)만 알수 있습니다.
        // => 아래 같은 코드를 생각해 보세요

        //      if (사용자입력값 == 1) r3 = new Cat();

        // 핵심 #3. r3 를 가지고는 Animal 로 부터 파생된 멤버만 접근가능
        // => Dog 고유 멤버 접근 안됨

        r3.Age   = 10; // ok
        r3.Color = 10; // error


    }
}