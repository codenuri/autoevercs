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


        // 핵심 #3. 멤버(필드) 접근

        r3.age = 10;
        r3.color = 10;
    }
}