// partial1.cs  partial2.cs 2개 빌드 되게 하세요

// 1. 하나의 프로그램 작성시 여러개 소스파일로 나누어 작성해도 됩니다.
// 2. Main 함수가 있는 클래스는 반드시 한개만 있어야 합니다.


class Button { }

// partial class : 하나의 클래스를 여러개 파일로 나누어 작성하는 기술
// => 모든 파일에서 "partial" 을 붙여야 합니다.
partial class Window
{
    public void Show() 
    {
        Console.WriteLine("Window is shown"); 
    }   
}

class Program
{
    static void Main()
    {
        Button b1= new Button();
        Slider s1 = new Slider();   

        Window w = new Window();
        w.Show();
        w.Hide();
    }
}

// 왜 하나의 클래스를 여러개 파일로 나누나요 ?

// 1. 하나의 클래스를 여러명의 개발자가 같이 만들때
// 2. 하나의 클래스를 "사람개발자 + 기계" 가 같이 작업할때 - 오후수업