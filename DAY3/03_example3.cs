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
                    // 현재 s는 List<Shape> 이므로
                    // e의 타입은 Shape 이다
                    // Shape 타입인 e 로는 파생 클래스가 추가한
                    // Draw() 메소드를 호출할수 없다 
                    e.Draw(); // error
                }
            }
        }
    }
}
// 위 코드는 왜 에러일까요 ?
// 해결책을 뭘까요 ?