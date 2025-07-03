using static System.Console;

// 핵심 #5. 올바른 해결책!

// 1. 모든 파생 클래스(도형)의 공통의 특징은 반드시 기반 클래스(Shape)에도
//    있어야 한다.
//    => 문법적인 규칙이 아닌!!
//    => 디자인 원칙
//    => 그래야 Shape 참조로 Draw() 호출이 가능해 진다.




class Shape
{
    public int color = 0;

    public void Draw() { WriteLine("Draw Shape"); }
}

class Rect : Shape
{
    public void Draw() { WriteLine("Draw Rect"); }
}
class Circle : Shape
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Triangle : Shape
{
    public void Draw() { WriteLine("Draw Triangle"); }
}


class Program
{
    public static void Main()
    {
        List<Shape> c = new List<Shape>();

        while (true)
        {
            int cmd = int.Parse(ReadLine());

            if (cmd == 1) { c.Add(new Rect()); }
            else if (cmd == 2) { c.Add(new Circle()); }
            else if (cmd == 9)
            {
                foreach (Shape s in c)
                {
                    s.Draw();
                }
            }
        }
    }
}
