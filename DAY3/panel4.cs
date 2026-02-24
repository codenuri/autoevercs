// panel1.cs
using System.Windows;
using System.Windows.Controls;

// 프로그램을 배우는 것은 ?
// 1. 프로그래밍 언어(C#, C++, Java, Python 등) 문법
// 2. 해당 언어로 만들어진 라이브러리 사용법

// 라이브러리 사용시 대부분 지켜야 하는 규칙들이 있습니다.
// => Framework 라고 합니다. - 각 라이브러리는 자신만의 규칙이 있습니다.
// => WPF : Window Presentation Framework

// WPF 규칙중 한개
// => 윈도우에 여러개 자식컨트롤을 붙이려면 Panel 을 사용해야 한다.

class MainWindow : Window
{
    public MainWindow()
    {
        DockPanel dp = new DockPanel();
        Content = dp;
                
        TextBox tb = new TextBox();
        StackPanel sp = new StackPanel();

        DockPanel.SetDock(tb, Dock.Top);
        DockPanel.SetDock(sp, Dock.Bottom);

        dp.Children.Add(sp);
        dp.Children.Add(tb);


        sp.Children.Add(new Button { Content = "OK" });
        sp.Children.Add(new Button { Content = "Cancel" });

    }
}

class Program
{
    [STAThread]
    public static void Main()
    {
        MainWindow w = new MainWindow();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}