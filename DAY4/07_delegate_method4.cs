using static System.Console;

// multicast 

delegate void MyFunc(int arg);

class Program
{
	public static void SMethod(int arg) => WriteLine("Program.SMethod");

	public static void Main()
	{	
		// 핵심 : +=을 사용하면 2개이상의 메소드 등록가능합니다
		MyFunc f = Test.SMethod; 
		f += Program.SMethod;

		
		f(10); // 2개 호출

		f -= Test.SMethod; // 제거도 가능
		f(10); 
    }
}

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}
