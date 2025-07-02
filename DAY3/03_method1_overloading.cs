using static System.Console;

// method overloading
// => 인자의 타입이나, 갯수가 다르면 동일 이름의 메소드를 여러개 만들수 있다.

// 대부분의 객체지향 언어가 지원하는 문법
// 단, C 언어와 Python 이 이문법 지원 안함.

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
    public int Square()
    {
        return 0;
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