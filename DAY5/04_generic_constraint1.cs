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
    // 임의 타입의 인자 2개를 받아서 큰 값을 반환하는 함수
    // 비교 연산자(<, >) : 수치 타입만 가능, string 안됨
    // CompareTo : 크기 비교가 가능한 대부분의 타입에 있는 메소드

    // 아래 코드는 에러입니다. !!!
    public static T Max<T>(T a, T b) 
    {
        //return a < b ? b : a;
        return a.CompareTo(b) > 0 ? a : b;
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
