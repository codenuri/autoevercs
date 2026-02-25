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
