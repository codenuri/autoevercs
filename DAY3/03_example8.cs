using static System.Console;

// 핵심 #9. abstract

class Shape
{
    private int color = 0;

    public void SetColor(int c) { color = c; }




    public virtual void Draw() { WriteLine("Draw Shape"); }

    public virtual Shape Clone()
    {
        Shape s = new Shape();
        s.color = color;
        return s;
    }
    public virtual int GetArea() { return 0; }
}



class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }

    public override Shape Clone()
    {
        return new Rect();
    }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("Draw Circle"); }

    public override Shape Clone()
    {
        return new Circle();
    }
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
            else if (cmd == 8)
            {
                Console.Write("몇번째 만들었던 도형을 복제할까요 >> ");
                int k = int.Parse(Console.ReadLine());

                s.Add(s[k].Clone());

            }
        }
    }
}


