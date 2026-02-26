using System;
using static System.Console;


class Point
{
    public int X { set; get; } = 0;
    public int Y { set; get; } = 0;
    public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // 아래 코드가 에러인 이유
    // => "임의 타입 T" 에 "CompareTo" 가 있다는 보장이 없다
    /*
    public static T Max<T>(T a, T b)
    {
        // 이 안에서 할수 있는 작업은 "Object" 가 할수 있는 것만 가능
        // string s = a.ToString(); // ok

        return a.CompareTo(b) > 0 ? a : b;
    }
    */
    
    // 이럴때 사용하는 기술이 "Generic constraint(제약)" 입니다.
    // => 제약을 만족하는 타입만 사용할수 있다는 의미

    // "T 는 IComparable 인터페이스를 구현한 것만 사용할수 있다"
    public static T Max<T>(T a, T b) where T : IComparable
    {
        // IComparable 을 구현한 타입은 CompareTo 가 있다는 보장이 있다
        return a.CompareTo(b) > 0 ? a : b;
    }

    public static void Main()
    {
        WriteLine($"{Max(10, 20)}");
        WriteLine($"{Max("AAA", "CC")}");

        Point p1 = new Point(1,2);
        Point p2 = new Point(1, 2);

        Max(p1, p2); // error. Point 는 IComparable 인터페이스 구현안함
    }

}
