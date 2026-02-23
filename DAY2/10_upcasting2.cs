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
    // 그럼, Object 로 받으면 모든 객체를 받을수 있지 않나요 ?
    public static void Foo(object obj)
    {
        // 하지만 이경우 Age 접근하려면 캐스팅 필요
    }

    public static void Main()
    {
        NewYear(new Dog());
        NewYear(new Cat());
        NewYear(10); // error

        Foo(new Dog()); // ok
        Foo(new Cat()); // ok
        Foo(10); // ok. 

        Dog[] arr1 = new Dog[10]; // Dog 객체 10개 보관 배열
        arr1[0] = new Dog();
        arr1[1] = new Cat();  // error

        Animal[] arr2 = new Animal[10]; // 모든 동물을 보관하는 배열
                                        // 동종을 보관하는 컬렉션
        arr2[0] = new Dog(); // ok
        arr2[1] = new Cat(); // ok

    }
}