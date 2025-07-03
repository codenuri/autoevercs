// 05_interface0.cs - example6.cs 복사

using static System.Console;

// 가상 메소드 : 파생 클래스가 override 안해도 됩니다.
//              override 안하면 기반 클래스가 기본 구현 제공 합니다.

class Shape
{
    public int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }
}

class Rect : Shape
{
//    public override void Draw() { WriteLine("Draw Rect"); }
}

class Program
{
    public static void Main()
    {
        Shape s = new Rect();
        s.Draw();
    }
}
