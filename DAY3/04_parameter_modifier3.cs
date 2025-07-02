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