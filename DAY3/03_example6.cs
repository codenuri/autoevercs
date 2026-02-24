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
            else if ( cmd == 8 )
            {
                Console.Write("몇번째 만들었던 도형을 복제할까요 >> ");
                int k = int.Parse( Console.ReadLine());

                // k 번째 도형의 복사본을 생성해서 s 에 추가합니다.
                // 어떻게 만들어야 할까요 ?
                // k 번째 도형은 어떤 타입일까요 ?
            }
        }
    }
}


