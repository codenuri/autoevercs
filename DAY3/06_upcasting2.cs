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
        Dog d = (Dog)a;

        d.color = 10; // ok
    }
}