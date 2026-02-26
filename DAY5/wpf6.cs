using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

// step6. XML 로 Button 이 아닌 "패널 + 자식 컨트롤" 생성
class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello, WPF";

        //--------------------------------------------------
        FileStream fs = new FileStream("../../../ui2.txt",
                                       FileMode.Open, FileAccess.Read);

        StackPanel sp = (StackPanel)XamlReader.Load(fs);

        fs.Close();
        //--------------------------------------------------
        this.Content = sp;

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
