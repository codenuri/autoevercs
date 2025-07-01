
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
// C# 은 객체지향 언어 입니다. 그래서 C# 을 배우는 것은

// 1. Rect 같은 타입을 만들때 사용하는 class 문법을 배워야 합니다.
// => public, 생성자, static 등의 문법

// 2. C# 표준에는 이미 분야별로 수백 ~ 수천개의 타입이 만들어져 있습니다.
// => 만들어진 타입(클래스) 사용법을 알아야 합니다.
// => 각 타입별 메소드의 속성등.. 