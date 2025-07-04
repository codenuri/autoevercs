// console
// property.cs

class Point
{
    private int x = 0;

    public int X
    {
        set { x = value; }
        get { return x; }   
    }
}
class Program
{
    public static void Main()
    {
        Point pt = new Point();
        pt.X = 10;
    }
}