using static System.Console;

// 핵심 #4. 해결책 #1
// => 아래 코드는 아무 문제 없이 잘 실행됩니다.

// 그런데,,, 단점은

// => 새로운 도형(Triangle)이 추가되면 
// => 기존 코드(cmd == 9 의 캐스팅 구문) 이 추가(변경)되어야 합니다.
// => OCP 이론을 만족할수 없는 유연성없는 경직된 코드 입니다.

// 기능 확장에 열려 있고(Open, 새로운 클래스가 추가되어도)
// 코드 수정에는 닫혀 있어야(Close, 기존 코드는 수정되지 않아야 한다)
// 는 이론(Principle)




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
