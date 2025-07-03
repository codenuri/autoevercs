using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    // object 의 Equals 기본 구현은 "객체의 동일성" 조사인데
    // override 해서 "상태의 동일성" 조사로 변경합니다.
    public override bool Equals(object? obj)
    {
        Point pt = (Point)obj;       

        return x == pt.x && y == pt.y;
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

// 핵심 C# 의 다양한 라이브러리(WPF, Window, Button 등) 사용시
// reference type 은 대부분
// 1. == 로 조사하면 "동일한 객체"인가를 조사
// 2. 상태 조사하면 Equals() 사용하세요
//    (Button 같은 클래스가 Equals() 를 override 해 놓았다는 것)

// value type 은 == 자체가 상태 조사
