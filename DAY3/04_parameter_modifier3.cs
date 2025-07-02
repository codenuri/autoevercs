using static System.Console;

class Example
{
    public static void no_modifier_parameter(int x)
    {
        // x 는 복사본 생성한것
        // R/W 모두 가능.
        // 아래 코드가 있어도 되고 없어도 된다.
//        int n = x; // A  Read
//        x = 0;     // B  Write

    }

    public static void out_parameter(out int x)
    {
        // x는 담기 위한 참조, 초기값이 없을수도 있습니다.
//      int n = x; // 에러, 초기값 없을수 있음
//      x = 0;     // ok. 
                   // 핵심 : 이줄이 없어도 에러!!!
                   //        담아주기로 했는데, 담아주지 않으면
                   //        이메소드 호출후 해당 변수를 사용할수 없게 되므로
    }

    public static void ref_parameter(ref int x)
    {
        // x 는 R/W 위한 참조 변수, 초기화 되어 있음.
        //int n = x; // ok
        //x = 0;     // ok
        //=> 위 2줄없어도 에러 아님. 
    }
}

class Program
{
	public static void Main()
	{
		int n1;		
		int n2 = 0; 

        Example.out_parameter(out n1); 
        Example.out_parameter(out n2); 

        Example.ref_parameter(ref n1); 
        Example.ref_parameter(ref n2); 

        Example.out_parameter(out int n3); 
	}
}

// 객체지향 프로그램의 핵심
// => 필요한 타입을 먼저 만들자

// 지금까지 배운것
// => 한개의 타입을 만들때 필요한 class 문법
// => 생성자, private/public, static, property ...

// 모든것을 이해 했어도..
// => Date 같은 한개의 클래스만 만들수 있다.

// 수십 ~ 수백개의 클래스를 섞어서 완전한 객체지향을 만드는 법은 배우지 않았다.
// => 상속!!