// ex8-1
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;


// ex9-2.xaml 추가 (발음은 자멜, 자믈)
// 속성 에서 빌드없음


class MainWindow : Window
{
    public MainWindow()
    {
        FileStream fs = new FileStream("../../../ex9-1.xaml", FileMode.Open);

        Button btn = (Button)XamlReader.Load(fs);

        fs.Close();

        this.Content = btn;
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

