using static System.Console;

class Rect
{
    public int left = 0;
    public int top = 0;
    public int right = 0;
    public int bottom = 0;

    public int GetArea()
    {
        return (right - left) * (bottom - top);
    }

    public Rect(int x1, int y1, int x2, int y2)
        => (left, top, right, bottom) = (x1, y1, x2, y2);

    public Rect() { }
}
class Program
{
    public static void Main()
    {
        // 핵심 : 용어
        int n = 10;
        n = 20;

        Rect rc = new Rect(1, 1, 10, 10);   

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}");
    }
}