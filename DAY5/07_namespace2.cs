
namespace Graphic
{
    class Point
    {
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public Point(int a, int b) => (X, Y) = (a, b);
        public override string ToString() => $"({X}, {Y})";
    }
    // namespace 는 중첩 될수 있습니다.
    namespace Engine
    {
        class Card { }
    }
}



class Program
{
    static void Main()
    {
        Graphic.Point p1 = new Graphic.Point(1, 2);
        Graphic3D.Point p2 = new Graphic3D.Point(1, 2, 3);

        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());



        Point p3 = new Point(1, 2);
        Console.WriteLine(p2.ToString());
    }
}
