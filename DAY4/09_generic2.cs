// class 도 generic 가능합니다.

class Point<T>
{
    private T x = default;
    private T y = default;

    public Point(T a, T b)
    {
        (x, y) = (a, b);
    }
}
class Program
{
    public static void Main()
    {
        // class generic 은 반드시 타입인자 보내야 합니다.
        Point<int> p1 = new Point<int>(1, 2);
    }
}