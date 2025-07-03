using static System.Console;

// 핵심 #5. 올바른 해결책!



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
