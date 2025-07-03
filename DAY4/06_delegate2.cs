using System;
using static System.Console;

// �ٽ� #1. delegate ����� �� ��Ȯ�� �˾ƾ� �մϴ�.
// => delegate1.cs �ּ��� �ݵ�� �ܿ켼��

// �ٽ� #2. ����

delegate void MyFunc(int arg);

/*
// => �� ������ ���� �����Ϸ��� �Ʒ� ó�� �����մϴ�.
// => "MyFunc" ��� �̸��� Ŭ���� ����
class MyFunc : MulticastDelegate
{
    // �Լ�(��ȯŸ�� void, ���� int�Ѱ���) �ּҵ��� �����ߴٰ� ȣ���Ҽ� �ֵ����ϴ�
    // ������ �ڵ� ����
}
*/





class Program
{
    public static void Main()
    {

        // MyFunc �� �ᱹ Ŭ������ ���� Ÿ���Դϴ�.
        // => C# ���� ��� Ÿ���� ��ü�� "new" �� ������ �մϴ�.
        // => �׷��� �Ʒ� �ڵ尡 ��Ȯ�� �ڵ�
        MyFunc f1 = new MyFunc(Foo);
        f1(10);


        // delegate �� ���� ǥ����� �����ϱ� ������
        // �Ʒ� ó�� ��밡���մϴ�.
        // �Լ��� signature�� ������ �Լ��� ��ϰ���
        // => signature(�Լ� ����Ÿ�԰� ���� Ÿ��, ����)
        MyFunc f = Foo; 

        f(10); 

    }


    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}
