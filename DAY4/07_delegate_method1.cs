using static System.Console;

// MyFunc : void(int) ������ �޼ҵ常 ���� �����մϴ�.
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

        t.IMethod(1);    // instance method�� ��ü�̸����� ȣ��
        Test.SMethod(1); // static method�� Ŭ���� �̸����� ȣ��
        

        // Test �� SMethod �� IMethod �� ���� f1, f2 ����� ������
        MyFunc f1 = ?;  
        MyFunc f2 = ?;  


        f1(10);  // Test SMethod ȣ��
        f2(10);  // Test IMethod ȣ�� �ǰ� �غ�����


    }
}
