using static System.Console;

class Example
{

    // optional parameter
    // => 인자를 전달하지 않으면 디폴트 값 사용
    // => C++/C#/Python 지원
    // => Java 안됨.
    public void M1(int a, int b, int c = 0)
    {
    }
}

class Program
{
    public static void Main()
    {
        Example e = new Example();

        e.M1(1, 2, 3);
        e.M1(1, 2);
    }
}