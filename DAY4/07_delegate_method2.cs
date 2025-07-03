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
        MyFunc f1 = Program.SMethod;
        MyFunc f2 = SMethod;


        // 자신의 instance method 등록
        // 핵심 : 현재 Main 메소드는 static 이므로 Program 객체(this)가 없다
        // 객체를 만들어야 IMethod 사용가능
        Program pg = new Program();

        MyFunc f3 = pg.IMethod;
//      MyFunc f4 = IMethod; // 될까요 ? error.
                             // Main 은 static 이므로 this 없습니다

        pg.InstanceMethod();
    }

	public void InstanceMethod()
	{
        // 현재 메소드가 호출되었다는 것은 객체 가 있다는 것
        MuFunc f1 = this.IMethod; //ok
        MuFunc f2 = IMethod;      // ok
    }
}
