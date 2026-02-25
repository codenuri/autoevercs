using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public override bool Equals(object obj)
    {
        Point pt = (Point)obj;

        return pt.x == x && pt.y == y;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // p3, p4 가 "상태가 동일한지 조사" 하는 최선의 코드를 작성해 보세요
        bool b; // 결과를 b에 담아 보세요

        // ... 

        Console.WriteLine($"{b}");
    }
}
