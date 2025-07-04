using System.Windows;
using System.Windows.Media;

// 핵심 : Window, Application 클래스를 직접 사용하지 말고
// => 파생 클래스를 만들어서 사용
// => Window 객체의 이벤트는 Window 클래스가 처리

class MainWindow : Window
{
    public MainWindow()
    {
        this.MouseLeftButtonDown += MainWindow_MouseLeftButtonDown;
    }

    private void MainWindow_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("LBUTTON");
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
        App app = new App();

        MainWindow w = new MainWindow();
        w.Show();

        app.Run();
    }
}