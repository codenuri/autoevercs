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
    public static bool operator ==(Point pt1, Point pt2)
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
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        // 정리

        // #1. 동일 객체 조사
        bool b1 = (p1 == p2); // == 연산자 사용. 대부분 잘 동작
                              // 하지만 항상 동일 객체라는 보장은 없음

        bool b2 = object.ReferenceEquals(p1, p2); // ok.. 항상 보장. 권장


        // #2. 동일 상태 조사
        bool b3 = p1.Equals(p2); // Point 타입에서 Equals 를 override 해서
                                 // 동일 상태 조사 코드를 만든 경우만 동작
                                 // 하지만 이 코드는 최선은 아님

        bool b4 = object.Equals(p1, p2);
                                // p1 == p2 를 먼저 조사후 false 인경우만
                                // p1.Equals(p2) 로해서 성능향상

    }

