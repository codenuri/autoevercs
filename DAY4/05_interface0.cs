// 05_interface0.cs - example6.cs 복사

using static System.Console;

// 가상 메소드 : 파생 클래스가 override 안해도 됩니다.
//              override 안하면 기반 클래스가 기본 구현 제공 합니다.

// 추상 메소드 ( abstract method)
// => 구현이 없고, 이름만 있는 메소드
// => 반드시 파생 클래스가 override 해서 구현을 제공해야 한다.
// => 추상 메소드를 만들려면, 클래스 자체도 추상(abstract) 이어야 한다.

abstract class Shape
{
    public int color = 0;

    public abstract void Draw();
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
