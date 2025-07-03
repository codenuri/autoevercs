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
    // 제약(constraint) 를 가지는 generic (java 도 동일한 개념있습니다.)
    // => 모든 타입에 대해 사용할수 있는 것이 아니라
    // => 조건을 만족하는 타입만 사용가능
    // => 아래 코드의 조건은 "IComparable" 인터페이스를 구현한 타입만 가능
    public static T Max<T>(T a, T b) where T : IComparable
    {
        // 이 안에서는 "IComparable" 인터페이스 안에 있는 메소드 
        // 사용가능.

        return a.CompareTo(b) < 0 ? b : a; 
    }

    public static void Main()
    {
        WriteLine($"{Max(10, 20)}");
        WriteLine($"{Max("AAA", "CC")}");


        Point p1 = new Point(0,0);
        Point p2 = new Point(1,0);

        Max(p1, p2);
    }

}
