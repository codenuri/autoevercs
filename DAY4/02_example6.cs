using static System.Console;

// 결국 가상함수는
// => Shape 참조로 도형객체를 관리할때
// => Rect 가 가상함수를 override 하면 새로 만든것 호출해 달라는것




class Shape
{
    public int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }
}

class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }
}
class Circle : Shape
{
    public override void Draw() { WriteLine("Draw Circle"); }
}

class Triangle : Shape
{
    public override void Draw() { WriteLine("Draw Triangle"); }
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
