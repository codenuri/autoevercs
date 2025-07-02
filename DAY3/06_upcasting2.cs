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
// upcasting2.cs
class Program
{
    public static void Main()
    {
        // #1. a 는 객체 자체는 아니고 힙에 있는 객체를 가리키는 참고 입니다.
//      Animal a = new Dog();
        Animal a = new Cat();


        // #2. Animal 타입인 a 로는 Dog 고유멤버 접근안됨
        //      a.color = 10; // error. 


        // #3. Dog 고유 멤버에 접근하려면 a 를 다시 Dog 참조로
        // => 단 아래 코드는 a 가 가리키는게 Dog 라는 확신이 있어야 합니다.
        // => 아닌 경우 runtime error
//      Dog d = (Dog)a;
//      d.color = 10; // ok

        // #4. 확신이 없으면 조사 하세요

        // #4-1. is 연산자 #1
        if ( a is Dog )  // a의 자체의 타입이 아닌 가리키는 객체 조사
        {
            Console.WriteLine("Dog 맞음 #1");
            Dog d = (Dog)a; // 항상 안전
            d.color = 10;
        }

        // #4-2. 위 코드는 아래 처럼하는게 편리합니다. 위와 동일
        if ( a is Dog d ) // Dog 라면 캐스팅까지 해서 d에 담아 주는것
        {
            d.color = 10;
        }

        // #4-3. as
        // is : 조사하는 것
        // as : 캐스팅 하는것
        Dog d1 = (Dog)a;   // 가리키는 객체가 Dog 가 아니면 runtime error
        Dog d2 = a as Dog; // 가리키는 객체가 Dog 가 아니면 null 반환

        if ( d2 != null )
        {
            d2.color = 10;
        }
    }
}