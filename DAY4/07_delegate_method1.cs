using static System.Console;

// MyFunc : void(int) 형태의 메소드만 보관 가능합니다.
delegate void MyFunc(int arg);


class Test
{
    public static void SMethod(int arg) => WriteLine("Test.SMethod");
    public        void IMethod(int arg) => WriteLine("Test_Object.IMethod");
}

class Program
{
    public static void Main()
    {
        Test t = new Test();

        t.IMethod(1);    // instance method는 객체이름으로 호출
        Test.SMethod(1); // static method는 클래스 이름으로 호출
        

        // Test 의 SMethod 와 IMethod 를 각각 f1, f2 등록해 보세요
        MyFunc f1 = ?;  
        MyFunc f2 = ?;  


        f1(10);  // Test SMethod 호출
        f2(10);  // Test IMethod 호출 되게 해보세요


    }
}
