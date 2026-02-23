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
//  public static void NewYear(Dog d) // Dog 객체만 전달 가능
    public static void NewYear(Animal a) // 동종을 전달 받을수 있다
    {                                    // 동일 기반 클래스로 부터 파생된
        ++a.Age;                         // 타입. 모든 동물 전달가능

//      a.Color = 10; // error

        if ( a is Dog)
        {
            Dog d = (Dog)a;
            d.Color = 10;
        }
    }

    public static void Main()
    {
        NewYear(new Dog());
        NewYear(new Cat());

    }
}