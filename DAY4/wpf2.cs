using System.Windows;
using System.Windows.Controls;

class MainWindow : Window
{
    private Button btn1 = null;
    private Button btn2 = null;
    private TextBox tb = null;
    private Slider sd = null;

    public MainWindow()
    {
        StackPanel sp = new StackPanel();
        this.Content = sp;   // this 없어도 됩니다.        
        //-------------------------------

        // 자식 컨트롤 만들어서 패널에 부착
        btn1 = new Button { Content = "ok1" };
        btn2 = new Button { Content = "ok1" }
        tb = new TextBox { Width = 100, Height = 50 };
        sd = new Slider();

        sp.Children.Add(tb);
        sp.Children.Add(btn1);
        sp.Children.Add(sd);
        sp.Children.Add(btn2);
        //--------------------------------

    }
}

class Program
{
    [STAThread]
    public static void Main()
    {
        MainWindow w = new MainWindow();
        Application app = new Application();

        w.Show();
        app.Run();
    }

}
