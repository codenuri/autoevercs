using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;

// step8

class MainWindow : Window
{
    public MainWindow()
    {
        this.Title = "Hello, WPF";

    }
}

class App : Application
{
    [STAThread]
    public static void Main()
    {
        //--------------------------------------------------
        FileStream fs = new FileStream("../../../ui4.txt",
                                       FileMode.Open, FileAccess.Read);

        Window w = (Window)XamlReader.Load(fs);

        fs.Close();
        //--------------------------------------------------

        w.Show();

        App app = new App();
        app.Run();
    }
}
