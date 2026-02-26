class Point<T>
{
//  private T x = 0; // error. 임의 타입이 0으로 초기화 된다는 보장이 없다

    // default : 타입의 디폴트값 - 1x page
    // 수치 타입(int, double..) : 0
    // referfence type : null
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
        Point<double> p1 = new Point<double>(1.1, 2.2);
        Point<int> p2    = new Point<int>(1, 2);

        // 이제 아래 코드가 정확히 이해되는지 생각해 보세요
        List<int>    s1 = new List<int>();
        List<double> s2 = new List<double>();
    }
}