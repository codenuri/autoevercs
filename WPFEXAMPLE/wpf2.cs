using System.Windows;
using System.Windows.Media;

// step2. Window 와 Application 클래스
// => WPF 에서는 수천개의 클래스가 있지만 핵심 클래스는 2개

// Window      : 프로그램의 주 윈도우를 만들때 사용
// Application : 프로그램의 시작, 끝, event 루프를 담당

// 관례는 WPF 클래스에서 상속 받아서 사용
class MainWindow : Window
{
    // 주된 UI 담당
}
class App : Application
{
    protected override void OnExit(ExitEventArgs e)
    {
        Console.WriteLine("프로그램이 종료");
        base.OnExit(e);
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        Console.WriteLine("프로그램이 시작됩니다. 여기서 로고화면 나타내기");
        base.OnStartup(e);
    }
}
class Program
{
    [STAThread]
    public static void Main()
    {
        MainWindow w = new MainWindow();
        w.Show();

        App app = new App();
        app.Run();
    }
}