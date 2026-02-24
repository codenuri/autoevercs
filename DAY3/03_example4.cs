using static System.Console;

// 핵심 #4. 해결책 #1. 캐스팅

class Shape
{
    private int color = 0;
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
        List<Shape> s = new List<Shape>();

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1)
            {
                s.Add(new Rect());
            }
            else if (cmd == 2)
            {
                s.Add(new Circle());
            }
            else if (cmd == 9)
            {
                foreach (var e in s)
                {
                    if (e is Rect)
                    {
                        Rect r = (Rect)e;
                        r.Draw();
                    }
                    else if (e is Circle )
                    {
                        Circle c = (Circle)e;
                        c.Draw();
                    }
                }
            }
        }
    }
}

