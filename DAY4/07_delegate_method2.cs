using static System.Console;

delegate void MyFunc(int arg);

// delegate_method1 : SMethod 의 IMethod 는 Test 클래스 멤버
// 아래 코드         : SMethod 의 IMethod 는 자신(Program)클래스 멤버

class Program
{
    public static void SMethod(int arg) => WriteLine("SMethod");
    public        void IMethod(int arg) => WriteLine("IMethod");

    public static void Main()
    {
        // 자신의 static method 등록
        MyFunc f1 = ?;
        MyFunc f2 = ?;

        // 자신의 instance method 등록
        MyFunc f3 = ?;
        MyFunc f4 = ?;

    }

	public void InstanceMethod()
	{
	}
}
