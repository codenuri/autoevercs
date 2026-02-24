using static System.Console;

// 핵심 #7.

class Shape
{
    private int color = 0;

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
                    e.Draw();  
                }
            }
        }
    }
}


