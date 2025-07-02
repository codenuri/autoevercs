using static System.Console;

// C# : C언어의 일반(전역)함수를 만들수 없습니다.
//      모든 함수는 반드시 클래스의 메소드 이어야 합니다.

// TopLevel 코드에서 만드는 "일반 함수"는 결국 Main 안에 놓이게 됩니다.

// 핵심 : 아래 Math class 는 수학 관련 메소드를 제공하려고 만든것
// => 핵심은 데이타(필드)가 없습니다.
// => 단지, Square() 같은 메소드 만 제공하려고 만든것

// 모든 메소드를 객체없이 호출 가능하도록 static 으로!!
/*
class Math
{
    public static int Square(int x)
    {
        return x * x;
    }
    public static double Square(double x)
    {
        return x * x;
    }
}
class Program
{
    public static void Main()
    {
        var ret1 = Math.Square(3);
        var ret2 = Math.Square(3.3);
    }
}
*/

// 이미 C# 표준에 Math 클래스 있습니다.(Java 에도..)
class Program
{
    public static void Main()
    {
        var ret1 = Math.Square(3);
        var ret2 = Math.Square(3.3);
    }
}