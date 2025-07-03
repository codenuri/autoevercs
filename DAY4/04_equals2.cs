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

        // 객체의 동일성을 조사하는 2가지 방법
        // 1. == 연산자
        // 2. Equals() 가상함수

        // #1. == 연산자
        // => "동일한 객체인가" 를 조사
        Console.WriteLine($"{p1 == p2}"); // True
        Console.WriteLine($"{p3 == p4}"); // False

        // #2. Equals() 메소드
        // => 
        Console.WriteLine($"{p1.Equals(p2)}");
        Console.WriteLine($"{p3.Equals(p4)}");
    }
}
