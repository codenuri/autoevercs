using System.Windows;
using System.Windows.Media;

// 핵심 : 메세지(이벤트) 루프 만들기
// => Application 클래스 객체를 만들고 Run() 메소드 호출
// => 관례 : Application 객체는 Window 만들기 전에 생성

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window w = new Window();
        w.Show();
        
        app.Run();
    }
}