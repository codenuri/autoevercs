using static System.Console;

class CPoint
{
    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
}


class Program
{
    public static void F1(CPoint pt)
    {
        pt.X = 10;
        pt.Y = 20;
    }
    public static void Main()
    {

    }
}
