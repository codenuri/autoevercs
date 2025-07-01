using static System.Console;


class CPoint
{
    private int x;
    private int y;
    public CPoint(int a, int b) { x = a; y = b; }
}
struct SPoint
{
    private int x;
    private int y;
    public SPoint(int a, int b) { x = a; y = b; }
}
class Program
{
    public static void Main()
    {
        CPoint cp1 = new CPoint(1, 1);
        CPoint cp2 = cp1;

        cp2.x = 2;

        WriteLine(cp1.x); // ??


  

    }
}

