// wpf1.cs

// C# 은 수백 ~ 수천개의 미리 만들어진 클래스를 제공합니다.
// => 표준 라이브러리(BCL, Base Class Library) 라고 합니다.
// => 그중에서 UI 를 책임지는 클래스가 "WPF 라이브러리" 입니다.

// WPF 를 사용해 봅시다.
// 1. TopLevel Program 은 안됨. Main Method 방식

// 2. WPF 라이브러리를 사용하려면 프로젝트 설정에서
//    => WPF 를 사용하도록 변경해야 합니다.
//    => WPF 교재 4 page 참고


using System.Windows;

class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello");

        // 메세지박스 나타내기
        // => MessageBox 클래스의 static method 사용

        MessageBox.Show("Hello");
    }
}
