using static System.Console;

class Animal
{
    // non-virtual : 메소드 앞에 virtual 이 없는 것
    // => static binding 해달라는 의미
    // => 컴파일시 호출 결정
    public void Cry1() { WriteLine("Animal Cry1");}


    // virtual method : 메소드 앞에 virtual 이 있는것
    // => dynamic binding 해달라는 것
    // => 실행시 메모리 조사후 호출 결정
    public virtual void Cry2() { WriteLine("Animal Cry2"); }
}

class Dog : Animal
{
    // non-virtual 을 override 할때는 "new"
    public new void Cry1() { WriteLine("Dog Cry1");}

    // virtual 은 "override" 키워드 사용
    public override void Cry2() { WriteLine("Dog Cry2"); }
}

class Program
{
    public static void Main()
    {
		Animal ad = new Dog();

		ad.Cry1();  // ?
        ad.Cry2();  // ?
    }
}

