using static System.Console;

// 핵심 #4. 해결책 #1

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

            if (cmd == 1) { c.Add(new Rect()); }
            else if (cmd == 2) { c.Add(new Circle()); }
            else if (cmd == 9)
            {
                foreach (Shape s in c) 
                {
//                  ((Rect)s).Draw(); 

                    // s 를 조사후 Rect 나 Circle 로 캐스팅해서 사용
                    if ( s is Rect r )
                    {
                        r.Draw();
                    }
                    else if ( s is Circle ci )
                    {
                        ci.Draw();
                    }
                }
            }
        }
    }
}
