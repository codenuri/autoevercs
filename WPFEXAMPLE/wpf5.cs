using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

// step5. UI 를 XML 로 구축
// 1. ui1.txt 파일 추가(확장자는 아무것이나 상관없음)

class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello, WPF";

        //--------------------------------------------------
        FileStream fs = new FileStream("../../../ui1.txt", 
                                       FileMode.Open, FileAccess.Read);

        Button btn = (Button)XamlReader.Load(fs);

        fs.Close();
        //--------------------------------------------------
        this.Content = btn; 

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
