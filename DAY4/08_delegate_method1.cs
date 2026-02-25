using static System.Console;

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


        // #1. 다른 클래스(Test)의 메소드를 Program 클래스에서 사용할때
        // delegate 변수에 메소드 등록시
        // static method   : "클래스이름.메소드이름" 으로 등록
        // instance method : "객체이름.메소드이름" 으로 등록
        MyFunc f1 = Test.SMethod; 
        MyFunc f2 = t.IMethod;  

        f1(10); 
        f2(10); 


    }
}
