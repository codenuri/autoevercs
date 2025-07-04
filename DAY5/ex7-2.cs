using System.Windows;
using System.Windows.Media;

// 핵심 : "Content" 라는 속성
// => WPF 에서 가장 중요한 속성
// => Content 에 등록된 객체는 윈도우에 자동으로 나타나게 됩니다.

class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "ABCD";
        this.Content = "Hello";
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
