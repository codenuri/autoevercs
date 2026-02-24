using static System.Console;

// 핵심 #4. 해결책 #1. 캐스팅
// => 가능한 해결책 이지만 좋은 디자인은 아닙니다.

// OCP 개념
// 기능 확장에 열려 있고(Open, 새로운 요소(클래스)가 추가되어도)
// 코드 수정에는 닫혀 있어야(Close, 기존 코드는 수정되지 않게)
// 만들어야 한다는 이론(Principle)

// => 새로운 요소가 추가되어도 기존에 코드는 변경되지 않게 설계하는 것이
//    좋다는 이론
// => 항상 유지보수와 기능 확장을 생각하라는것

// => 아래 코드는 OCP 위반!!!
// => Triangle 추가시 Main 의 foreach 에서 if 문이 추가되어야 한다.


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

class Triangle : Shape
{
    public void Draw() { WriteLine("Draw Triangle"); }
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

