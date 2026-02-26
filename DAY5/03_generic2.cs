class Point<T>
{
    private T x = 0;
    private T y = 0;

    public Point(T a, T b)
    {
        (x, y) = (a, b);
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1.1, 2.2);
    }
}