using System.Drawing;
using System.Windows;
using System.Windows.Media;

// 핵심 
class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();

        // 윈도우 캡션 문자열을 "AAA"로 변경해 보세요
        // => 현재 윈도우를 관리하는 객체(변수)는 w
        // => 윈도우에 대해서 어떤 작업을 하고 싶다면
        // => "w." 후에 lookup table 에서 찾아라

        w.Title = "AAA";
        w.Width = 300;
        w.Height = 300;

//        w.Background = new SolidBrush(Colors.Yellow);

        Application app = new Application();
        app.Run();
    }
}
