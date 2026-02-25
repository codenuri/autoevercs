using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public override bool Equals(object obj)
    {
        Point pt = (Point)obj;

        return pt.x == x && pt.y == y;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

        // p3, p4 가 "상태가 동일한지 조사" 하는 최선의 코드를 작성해 보세요
        
        //----------------------------------------------------
        bool b = p3 == p4;  // 동일 객체인지 먼저 조사

        // 동일 객체가 아니라면 상태 조사
        if (b == false)
        {
            b = p3.Equals(p4);
        }
        //-----------------------------
        // 위 코드와 유사한 함수가 object 클래스가 제공하는
        // "Equals()" 라는 static method

        // p3.Equals(p4) : instance method(virtual)
        // object.Equals(p3, p4) : static method

        bool b2 = object.Equals(p4, p4);    

        Console.WriteLine($"{b}");
        Console.WriteLine($"{b2}");
    }
}
