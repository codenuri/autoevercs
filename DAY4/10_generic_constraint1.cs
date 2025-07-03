using System;
using static System.Console;


class Point
{
	public int X{set;get;} = 0;
	public int Y{set;get;} = 0;
	public Point(int x, int y) => (X, Y) = (x, y);
}


class Program
{
    // < 연산은 숫자 타입만 가능. 문자열 안됩니다.
    // CompareTo() 는 int, string 등 비교 가능한 모든 타입 사용가능

    // 그런데??? 왜 아래 코드가 에러일까요 ?
    public static T Max<T>(T a, T b) 
    {
		return a.CompareTo(b) < 0 ? b : a;
    }

    public static void Main()
    {
		WriteLine($"{Max(10, 20)}");
		WriteLine($"{Max("AAA", "CC")}");

        Foo(10, 20); 
    }





    public static void Foo<T>(T a, T b)
    {

    }
}
