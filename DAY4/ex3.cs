using System.Windows;
using System.Windows.Media;

// 핵심 : 메세지(이벤트) 루프 만들기
// => Application 클래스 객체를 만들고 Run() 메소드 호출

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}