// ex8-1
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;



class MainWindow : Window
{
    public void InitializeComponent()
    {
    }

    public MainWindow()
    {
        InitializeComponent();

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


        FileStream fs = new FileStream("../../../ex9-3.xaml", FileMode.Open);
        Window w = (Window)XamlReader.Load(fs);

        w.Show();
        app.Run();
    }
}

