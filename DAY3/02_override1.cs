using static System.Console;

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry"); }
}
class Dog : Animal
{
    // method override : 기반 클래스 메소드를 파생 클래스가 다시 만드는것

    // new 키워드를 붙여서 실수가 아니라 의도적으로 다시 만든것이라고 알려주어야 한다.
    // new 가 없으면 에러는 아니지만 경고
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
        Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();    // 1. Animal Cry
        d.Cry();    // 2. Dog Cry
    }
}
