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
    
    // ==, != 등의 연산자를 다시 만드는 것도 가능합니다.
    public static bool operator==(Point pt1, Point pt2)
    {
        return pt1.x == pt2.x && pt1.y == pt2.y;    
    }
    // == 만들면 반드시 != 도 만들어야 합니다.. 규칙
    public static bool operator !=(Point pt1, Point pt2)
    {
        return !(pt1 == pt2);
    }
}

class Program
{
    public static void Main()
    {
        // 동일객체 아님.
        // 상태는 동일
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        // 동일 객체 인지 조사
        // == 연산자 사용 : 대부분 의도대로 동작하지만
        //                 그렇지 않을수도 있습니다.
        Console.WriteLine($"{p1==p2}"); // False
    }
}
