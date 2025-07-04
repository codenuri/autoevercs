using System.Windows;
using System.Windows.Media;

// 핵심 : WPF 기본 코드 완성
// => Main method 를 위한 Program 클래스가 있을 필요 없다.
// => App 에 있으면 된다.


// 결국, 아래 코드는 모든 WPF 프로그램의 기본 구조
// => 2개의 클래스
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

    [STAThread]
    public static void Main()
    {
        App app = new App();
        MainWindow w = new MainWindow();
        w.Show();
        app.Run();
    }
}
