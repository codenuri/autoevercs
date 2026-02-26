using static System.Console;

// function overloading
// => 인자의 갯수나 타입이 다른 경우(호출 코드를 보고 구별 가능한 경우)
// => 동일 이름의 함수를 여러개 만들수 있다.

// 장점 : 함수 자체를 여러개 이지만, 사용자는 "한개"처럼 보이게 된다.
// => 일관된 형태의 라이브러리 구축에 도움이되는 문법

class Math
{
    public int Square(int x)
    {
        return x * x;
    }
    public double Square(double x)
    {
        return x * x;
    }
}

class Program
{
    public static void Main()
    {
        Math m = new Math();

        var ret1 = m.Square(3);
        var ret2 = m.Square(3.3);
    }
}