using System;
using static System.Console;


class Point
{
	public int X{set;get;} = 0;
	public int Y{set;get;} = 0;
	public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // < ������ ���� Ÿ�Ը� ����. ���ڿ� �ȵ˴ϴ�.
    // CompareTo() �� int, string �� �� ������ ��� Ÿ�� ��밡��

    // �׷���??? �� �Ʒ� �ڵ尡 �����ϱ�� ?
    public static T Max<T>(T a, T b) 
    {
		return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    {
		WriteLine($"{Max(10, 20)}");
		WriteLine($"{Max("AAA", "CC")}");

        Foo(10, 20); 
    }





    public static void Foo<T>(T a, T b)
    {

    }
}
