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

        // 핵심 : 아래 한줄은 어느 함수를 호출할까요 ?
        ad.Cry(); // ?
    }
}
