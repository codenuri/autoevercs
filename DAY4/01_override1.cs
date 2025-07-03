using static System.Console;

// 104 page ~ 

class Animal
{
    public void Cry() { WriteLine("1. Animal Cry");}
}

class Dog : Animal
{
    // method override : 기반 클래스 메소드를 파생클래스가 다시 만드는 것
    // => new 가 없어도 에러는 아닌데, 경고 입니다
    // => "실수가 아닌 의도적으로 만든것이다" 라고 알려주기 위해 new 사용
    public new void Cry() { WriteLine("2. Dog Cry"); }
}

class Program
{
    public static void Main()
    {
		Animal a = new Animal();
        Dog d = new Dog();

        a.Cry();    // Animal Cry
		d.Cry();    // Dog Cry

        //----------------------------------
        // 아래 코드가 핵심 입니다.
        // => 메모리에 있는 객체 자체는 "Dog"
        // => 하지만 객체를 가리키는 참조는 "Animal" 타입
        
        Animal ad = d;

        // 아래 코드는 어떤 메소드를 호출할까요 ?
        // => 어떤 메소드를 호출하는게 논리적으로 맞을까요 ?
        //    객체 자체는 "Dog" 이므로 논리적으로는 Dog가 맞습니다.
        ad.Cry(); // ?

        // java, python, swift 등의 대부분의 객체지향언어 : Dog Cry 호출
        // C++/C# : Animal Cry
	}
}

