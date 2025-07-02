class Animal
{
    public int age = 0;
}

class Dog : Animal
{
    public int color = 0;
}

class Cat : Animal
{
    public int speed = 0;
}

class Program
{
    public static void Main()
    {
        Dog r1 = new Dog(); // ok
//      int r2 = new Dog(); // error

        // 핵심 #1. 기반 클래스 참조 로 파생 클래스 객체를 가리 킬수 있다.
        // => 상속 문법의 핵심!!!
        // => upcasting 이라고 합니다.
        // => 왜 되는지는 "메모리 그림" 을 생각하면 됩니다.

        // => r3가 가리키는 곳은 Dog 객체가 있지만
        //    Dog 객체의 윗부분이 결국 Animal 객체 모양과 동일하다.
        Animal r3 = new Dog(); // ?


        // 핵심 #2. 컴파일러는 컴파일 시간에 r3 가 가리키는 객체의 종류는
        //          알수 없다.
        // => r3 자체가 Animal 이라는 것만 알수 있다.

        //      if ( 사용자 입력 == 1) 
        //              r3 = new Cat();

        // 컴파일시 이 위치에서 r3가 어떤 객체를 가리키는지 알수 없다.
        // => 위코드가 있다면 실행시 입력 결과에 따라 달라 지므로


        // 핵심 #3. Animal 타입인 참조 r3 로는 Animal 고유의 멤버만 접근할수있다
        // => 실제 메모리에 Dog 가 있다해도, Dog 고유 멤버 접근 안됨

        // 이유 : 컴파일러는 r3 가 Dog 를 가리킨다는 확신이 없다.

        // static type check : 멤버 접근이 유효한지 컴파일 할때 확인하는 것
        //                      (C/C++/Java/C#)
        // dynamic type check : 멤버 접근이 유효한지 실행시간에 확인
        //                      해당 멤버가 없으면 실행시간 에러
        //                      (Python)

        r3.age = 10;    // ok
//      r3.color = 10;  // error

        // 핵심 #4. r3로 Dog 고유의 멤버에 접근하려면
        // => 개발자가 컴파일러에게 알려 줘야 한다.
        // => 캐스팅 필요

        ((Dog)r3).color = 10;
    }
}