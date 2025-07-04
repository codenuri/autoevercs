using System.Windows;
using System.Windows.Media;

// 핵심 : Window 객체에는 다양한 속성이 있습니다.
// => 각 속성을 잘 활용해야 합니다

class MainWindow : Window
{
    public MainWindow()
    {
        // 아래 코드에서 "this" 는 없어도 됩니다.

        this.Title = "Hello";
        this.Width = 300;
        this.Height = 300;

        this.Background = new SolidColorBrush(Colors.Magenta);
        this.Topmost = true;
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
