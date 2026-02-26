using static System.Console;

class CPoint
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
}
struct SPoint
{
    public int X { get; set; }
    public int Y { get; set; }
}

class Program
{
    public static void F1(CPoint pt)
    {
        pt.X = 10;
        pt.Y = 20;
    }
    // SPoint 는 value 타입이므로 아래 코드는 복사본 생성
    public static void F2(SPoint pt)
    {
        pt.X = 10;
        pt.Y = 20;
    }
    public static void Main()
    {
        CPoint cp = new CPoint { X = 0, Y = 0 };
        SPoint sp = new SPoint { X = 0, Y = 0 };

        F2(sp);
        Console.WriteLine("{sp.x}, {sp.y}");

        F1(cp);
        Console.WriteLine("{cp.x}, {cp.y}");
    }
}
