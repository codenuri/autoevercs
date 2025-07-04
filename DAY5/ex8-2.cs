// ex8-1
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


// 핵심 : Layout(Panel) 은 중첩 가능하다.
// => 기본 패널들의 조합(중첩)으로 어떠한 복잡한 형태도 모두 만들수 있다.

class MainWindow : Window
{
    public MainWindow()
    {
        Button btn1 = new Button { Content = "button1" };
        Button btn2 = new Button { Content = "button2" };
        Button btn3 = new Button { Content = "button3" };
        Button btn4 = new Button { Content = "button4" };

        StackPanel sp1 = new StackPanel();
        this.Content = sp1;

        StackPanel sp2 = new StackPanel();
        sp1.Children.Add(btn1);
        sp1.Children.Add(btn2);
        sp1.Children.Add(sp2);

        sp2.Orientation = Orientation.Horizontal;

        sp2.Children.Add(btn3);
        sp2.Children.Add(btn4);

        sp2.Height = 50;

        
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
