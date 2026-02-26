using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

// step4. UI 구축
// => MainWindow 에서 생성자를 만들고
// => Panel, Control 등을 부착
// => 다양한 Event 처리 코드 추가

class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello, WPF";

        StackPanel sp = new StackPanel();

        this.Content = sp;
        //----------------------------
        Button btn1 = new Button { Content = "OK1" };
        Button btn2 = new Button { Content = "OK1" };

        sp.Children.Add(btn1);
        sp.Children.Add(btn2);
        //----------------------------

        btn1.Click += Btn1_Click;

    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        Console.WriteLine("btn1 click");
    }
}

class App : Application
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
