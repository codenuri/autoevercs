using static System.Console;

// 핵심 #5. 모든 도형의 공통의 특징은 반드시 기반 클래스에도 있어야 한다.
// => 문법의 규칙이 아닌 "디자인의 규칙"
// => 모든 도형이 Draw()가 있다면  Shape 에도 Draw() 가 있어야 
// => Shape 참조로 Draw() 호출 가능

class Shape
{
    private int color = 0;

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


