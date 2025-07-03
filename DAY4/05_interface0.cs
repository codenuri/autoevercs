// 05_interface0.cs - example6.cs 복사

using static System.Console;

class Shape
{
    public int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }
}

class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }
}

class Program
{
    public static void Main()
    {
        Shape s = new Rect();
        s.Draw();
    }
}
