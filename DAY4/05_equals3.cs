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

        // 동일 객체 인지 조사
        // == 연산자 사용 : 대부분 의도대로 동작하지만
        //                 그렇지 않을수도 있습니다.
        Console.WriteLine($"{p1 == p2}"};
    }
}
