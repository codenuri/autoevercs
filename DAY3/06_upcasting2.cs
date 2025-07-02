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
        Animal a = new Dog();

        a.color = 10; // error. Animal 타입인 a 로는 Dog 고유멤버 접근안됨
    }
}