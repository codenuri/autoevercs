using System.Windows;
using System.Windows.Controls;

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        
        w.Title = "Hello"; // 윈도우의 캡션 문자열에 나타낼 문자열 설정

        // Content 속성 : 캡션바가 아닌 Window 자체에 나타낼 "컨텐츠" 연결
        w.Content = "Hello";




        w.Show();

        
        Application app = new Application();
        app.Run();
    }
}
