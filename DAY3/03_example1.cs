using static System.Console;

// 파워 포인트 같은 프로그램을 객체지향 프로그램으로 설계해 봅시다.

// 핵심 #1. 모든 타입을 클래스로 만든후 사용하면 편리하다

class Rect
{
    // left, top, right, bottom, 생성자등은 생략,
    // virtual 에 집중!

    public void Draw() { WriteLine("Draw Rect"); }
}

class Program
{
    public static void Main()
    {
        Rect r = new Rect();
        r.Draw();
    }
}