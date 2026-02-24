using static System.Console;

// 핵심 #2. 

// 모든 도형은 공통의 특징이 있습니다.
// => color 같은 특징..

// 공통의 기반 클래스인 Shape 가 있다면
// => 공통의 특징을 하나의 클래스(Shape) 에서 관리할수 있고
// => 모든 도형을 한개의 컬렉션(List<Shape>) 에 보관할수 있습니다.

class Shape
{
    private int color = 0;
}



class Rect
{
    public void Draw() { WriteLine("Draw Rect"); }
}

class Circle
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        // 만들어지는 모든 도형을 보관하기 위한 컬렉션
        List<Rect> s = new List<Rect>();

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1)
            {
                Rect r = new Rect();
            }
            else if (cmd == 2)
            {
                Circle c = new Circle();
            }
        }
    }
}