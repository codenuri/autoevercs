// 01_this3

// this 활용
// this 는 언제 사용하나요 ?

class Point
{
    private int x = 0;
    private int y = 0;

    public void SetX(int a)
    {
        x = a;
    }
    public void SetY(int a)
    {
        y = a;
    }
}

class Program
{
    public static void Main()
    {
        Point p = new Point();

        p.SetX(1);
        p.SetY(2);
    }
}
