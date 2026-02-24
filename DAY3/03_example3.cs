using static System.Console;

// 핵심 #3

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
            else if ( cmd == 9)
            {
                // 만들어진 모든 도형을 그리는 작업
                foreach( var e in s )
                {
                    e.Draw(); 
                }
            }
        }
    }
}
// 위 코드는 왜 에러일까요 ?
// 해결책을 뭘까요 ?