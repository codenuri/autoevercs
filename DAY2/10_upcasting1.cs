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
        // 이유 : 멤버(필드, 메소드) 접근이 유효 한가의 확인

        // C++, C#, Java : 컴파일 시간(static type check)
        // Python        : 실행시간(dynamic type check)

        // 컴파일러는 가리키는 곳의 타입을 알수 없다 - 핵심 #2.
        // 컴파일러가 알고 있는 것
        // r3 자체 타입 : Animal 이라는 것
        // r3 가 가리키는 곳의 객체의 타입 : 모른다!
        r3.Age   = 10; // ok
 //     r3.Color = 10; // error

        // 핵심 #4. Dog 고유 멤버에 접근하려면 캐스팅 해야 합니다.
        ((Dog)r3).Color = 10; // ok
                              // 단, 이경우 반드시 r3가 가리키는 곳이
                              // Dog 라는 확신이 있어야 합니다.
                              // Dog 가 아니면 runtime error

        // 핵심 #5. Dog 라는 확신이 없다면
        // => is 연산자로 조사후 사용하면 됩니다.
        if ( r3 is Dog )
        {
            // r3 자체는 아직 Animal 

            // Dog 타입 참조를 만들어서 r3 가 가진 주소를 담아서 
            // d 사용. 이러면 d를 계속 사용가능
            Dog d = (Dog)r3;    
            d.Color = 10;
        }

    }
}