using static System.Console;

// multicast 

delegate void MyFunc(int arg);

class Program
{
	public static void SMethod(int arg) => WriteLine("Program.SMethod");

	public static void Main()
	{	
		// 여러개 함수 등록가능
		MyFunc f = Test.SMethod;

		f += Program.SMethod;

		f(10); 
	}
}

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}
