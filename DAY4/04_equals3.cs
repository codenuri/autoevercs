using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = p1;

        Point p3 = new Point(1, 2);
        Point p4 = new Point(1, 2);

 
        // #1. == 연산자
        // => "동일한 객체인가" 를 조사
        Console.WriteLine($"{p1 == p2}"); // True
        Console.WriteLine($"{p3 == p4}"); // False

        // #2. Equals() 메소드
        // => object 클래스의 기본 구현은 "동일한 객체"인가 조사
        Console.WriteLine($"{p1.Equals(p2)}");
        Console.WriteLine($"{p3.Equals(p4)}");
    }
}
