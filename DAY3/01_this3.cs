// 01_this3

// this 활용
// this 는 언제 사용하나요 ?

class Point
{
    private int x = 0;
    private int y = 0;

    public Point SetX(int a)
    {
        x = a;
        return this;
    }
    public Point SetY(int a)
    {
        y = a;
        return this;
    }
}

class Program
{
    public static void Main()
    {
        Point p = new Point();

        p.SetX(1);
        p.SetY(2);

        // 위 2줄을 아래처럼 사용할수 있도록 변경해보세요
        p.SetX(1).SetY(2);

        // people.SetName("kim").SetAge(20).SetHeight(180)
    }
}
