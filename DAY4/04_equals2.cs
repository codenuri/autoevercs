using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // ��ü�� ���ϼ��� �����ϴ� 2���� ���
        // 1. == ������
        // 2. Equals() �����Լ�

        // #1. == ������
        // => "������ ��ü�ΰ�" �� ����
        Console.WriteLine($"{p1 == p2}"); // True
        Console.WriteLine($"{p3 == p4}"); // False

        // #2. Equals() �޼ҵ�
        // => 
        Console.WriteLine($"{p1.Equals(p2)}");
        Console.WriteLine($"{p3.Equals(p4)}");
    }
}
