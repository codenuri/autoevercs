using static System.Console;

// 핵심 #3. 아래 코드가 에러 나오는 이유 => 해결책은 다음 소스

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
        List<Shape> c = new List<Shape>();

        while (true)
        {
            int cmd = int.Parse(ReadLine());

            if (cmd == 1)      { c.Add(new Rect()); }
            else if (cmd == 2) { c.Add(new Circle()); }
            else if (cmd == 9)
            {
                foreach (var s in c) // A
                {
                    s.Draw(); // error. B
                }
            }
        }
    }
}
// 위 코드는 어디서 ? 왜 에러일까요 ?
// => A 에서 s 의 타입은 Shape 이다.
// => Rect, Circle 에는 Draw 가 있지만
// => 기반 클래스인 Shape 에는 Draw 가 없다.
// => 기반 클래스 참조로는 "파생 클래스 고유 멤버에 접근 안됨"