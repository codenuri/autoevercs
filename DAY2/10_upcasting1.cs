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
        Dog r1 = new Dog(); // ?

        int r2 = new Dog(); // ?

        Animal r3 = new Dog(); // ?

    }
}