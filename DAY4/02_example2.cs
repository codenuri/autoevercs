using static System.Console;

// 핵심 #2. 공통의 기반 클래스가 있다면
// => 모든 도형의 공통의 특징을 한곳에서 관리할수 있고
// => 모든 도형을 하나의 콜렉션(저장하는 객체)에 같이 보관할수 있다.

class Shape
{
    public int color = 0;
}

class Rect : Shape
{
    public void Draw() { WriteLine("Draw Rect"); }
}
class Circle : Shape
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        // 만들어지는 모든 도형을 보관할 객체
//      List<Rect> c = new List<Rect>(); // Rect 객체 만 보관 가능
        List<Shape> c = new List<Shape>(); // 모든 도형 객체 보관가능
    }
}