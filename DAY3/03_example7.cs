using static System.Console;

// 핵심 #8. virtual vs non-virtual 

class Shape
{
    private int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }
        
    public virtual Shape Clone()
    {
        Shape s = new Shape();
        s.color = color; 
        return s;
    }
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


