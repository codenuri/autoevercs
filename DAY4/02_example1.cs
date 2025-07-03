using static System.Console;

// 파워 포인트 같은 프로그램을 객체지향 프로그램으로 설계해 봅시다.

// 핵심 #1. 모든 도형을 타입으로 만들면 편리하다.

class Rect
{
    // x, y, w, h, 생성자등은 생략하고, 가상함수에만 집중..

    public void Draw() { WriteLine("Draw Rect"); }
}
class Circle
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect();
        rc.Draw();
    }
}