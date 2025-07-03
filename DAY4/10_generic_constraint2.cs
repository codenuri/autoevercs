using System;
using static System.Console;


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // ����(constraint) �� ������ generic (java �� ������ �����ֽ��ϴ�.)
    // => ��� Ÿ�Կ� ���� ����Ҽ� �ִ� ���� �ƴ϶�
    // => ������ �����ϴ� Ÿ�Ը� ��밡��
    // => �Ʒ� �ڵ��� ������ "IComparable" �������̽��� ������ Ÿ�Ը� ����
    public static T Max<T>(T a, T b) where T : IComparable
    {
        // �� �ȿ����� "IComparable" �������̽� �ȿ� �ִ� �޼ҵ� 
        // ��밡��.

        return a.CompareTo(b) < 0 ? b : a; 
    }

    public static void Main()
    {
        WriteLine($"{Max(10, 20)}");
        WriteLine($"{Max("AAA", "CC")}");


        Point p1 = new Point(0,0);
        Point p2 = new Point(1,0);

        Max(p1, p2);
    }

}
