// class �� generic �����մϴ�.

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
        // class generic �� �ݵ�� Ÿ������ ������ �մϴ�.
        Point<int> p1 = new Point<int>(1, 2);
    }
}