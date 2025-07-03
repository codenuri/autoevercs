using System;
using static System.Console;

// delegate �� ?
// => �Լ��� ȣ�� ����(�Լ��� �ִ� �޸� �ּҵ�)�� �����ߴٰ�
// => �ش��Լ��� ȣ���Ҷ� ���
// => C ����� �Լ� ������!


// delegate ����� ��
// 1. �Լ� ���� ����
// 2. �տ� delegate �߰�
// 3. �Լ� �̸��� ���ϴ� �̸����� ����

// �Ʒ� �ڵ忡�� "MyFunc" �� ���� Ÿ���Դϴ�.
// => �Լ��� ȣ�� ������ �����ߴٰ� ȣ���Ҷ� ���
delegate void MyFunc(int arg);


class Program
{
    public static void Main()
    {
        // ? Ÿ���� ä�� ������

        int n = 3;          // 3�� �����ؾ� �ϹǷ� int
        string s = "ABCD";  // ���ڿ��� �����ؾ� �ϹǷ� string

        MyFunc f = Foo; // �޼ҵ�(�Լ�)�� �����ϱ� ���� Ÿ��
                        // ���� : �̷����ؾ� Foo() ȣ��
                        //        Foo �� �޼ҵ� �̸�

        f(10); // Foo(10)�� ����, ��, ����� �Լ� ȣ��

    }


    public static void Foo(int arg)
    {
        WriteLine($"Foo : {arg}");
    }
}
