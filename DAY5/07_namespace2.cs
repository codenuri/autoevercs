
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
        class Card 
        { 
            public static void Test() 
            {
                Console.WriteLine("Card Test")
            }
        }
    }
}
class Program
{
    static void Main()
    {
        Graphic.Point p1 = new Graphic.Point(1, 2);

        // Card 객체 만들어 보세요
        ? c = new ?;

        // Card 클래스의 static method Test() 호출해 보세요
    }
}
