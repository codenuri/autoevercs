using static System.Console;

// multicast 

delegate void MyFunc(int arg);

class Program
{
	public static void SMethod(int arg) => WriteLine("Program.SMethod");

	public static void Main()
	{	
		// �ٽ� : +=�� ����ϸ� 2���̻��� �޼ҵ� ��ϰ����մϴ�
		MyFunc f = Test.SMethod; 
		f += Program.SMethod;

		
		f(10); // 2�� ȣ��

		f -= Test.SMethod; // ���ŵ� ����
		f(10); 
    }
}

class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}
