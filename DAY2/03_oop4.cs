
using System.Drawing;
using static System.Console;

class Program
{
    public static void Main()
    {
        // C# 언어에 이미 사각형 타입이 있습니다.
        // => Rectangle 클래스
        // => System.Drawing 라는 namespace 안에 있습니다
        Rectangle rc = new Rectangle(1, 1, 10, 10);
        
        // 그런데, C# 표준 타입의 Rectangle 은
        // => GetArea() 메소드는 없습니다.
        // => extension method 라는 기술로 추가 가능-4일차설명
//      int ret = rc.GetArea(); // error

//      Console.WriteLine($"{ret}");
    }
}