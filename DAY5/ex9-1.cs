// ex8-1
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;


// 핵심 : UI 는 C# 이 아닌 XML 로 만들자

// 1. ex9-1.xaml 추가
// 2. ex9-1.xaml 의 속성에서 "빌드 : 없음"


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

