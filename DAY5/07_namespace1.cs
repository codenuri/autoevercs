// 규모가 큰 프로젝트를 하면 "이름 충돌" 가능성이 있습니다.
// 개발자가 만든 클래스 이름 과 다른 개발자의 클래스 이름, 라이브러리의 클래스 이름

// 이런 경우는 namespace 문법으로 분리하세요

namespace Graphic
{
    class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public Point(int a, int b) => (X, Y) = (a, b);
        public override string ToString() => $"({X}, {Y})"; 
    }
}

namespace Graphic3D
{
    class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public int Z { get; set; } = 0;
        public Point(int a, int b, int c) => (X, Y, Z) = (a, b, c);
        public override string ToString() => $"({X}, {Y}, {Z})";
    }
}


class Program
{
    static void Main()
    {
        Graphic.Point   p1 = new Graphic.Point(1, 2);
        Graphic3D.Point p2 = new Graphic3D.Point(1, 2, 3);

        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
    }
}
