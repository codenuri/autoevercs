// ex8-1
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


class MainWindow : Window
{
    public MainWindow()
    {
        Button btn1 = new Button { Content = "button1" };
        Button btn2 = new Button { Content = "button2" };
        Button btn3 = new Button { Content = "button3" };
        Button btn4 = new Button { Content = "button4" };

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
