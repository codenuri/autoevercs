using System.Windows;
using System.Windows.Media;

// 핵심 : Window, Application 클래스를 직접 사용하지 말고
// => 파생 클래스를 만들어서 사용
// => Window 객체의 이벤트는 Window 클래스가 처리

class MainWindow : Window
{
    public MainWindow()
    {

    }
}

class App : Application
{
    public App()
    {

    }
}

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