// public field vs setter/getter
class Person1
{
    public int age;
}

class Person2
{
    private int age;    

    public int  GetAge() => age; // { return age; }

    public void SetAge(int value) 
	{ 
		if ( value > 0 )
			age = value; 
	}
}

class Program
{
    public static void Main()
    {
        Person1 p1 = new Person1();
		Person2 p2 = new Person2();
      
        // #1. Person1 은 age 가 publie field 이므로 아래 처럼 사용가능
        // => 사용하기 쉬워 보이고, 직관적이지만
        // => 안전하지 않다.
		p1.age = 10;
		int n1 = p1.age;

        p1.age = -10; // 단점 : 잘못된 값에 대한 방어수단이 없다.


        // #2. Person1 은 age 가 private field이므로
        // => SetAge(), GetAge() 메소드로 접근
        // => setter/getter 사용

        // => 안전 하지만
        // => 복잡해 보인다.
        p2.SetAge(10);
		int n2 = p2.GetAge();

        p2.SetAge(-10); // 장점 : 안전하다. 
                        // 객체의 상태는 -10이 되지 않는다.

	
    }
}
