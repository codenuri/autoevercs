// panel1.cs
using System.Windows;

class MainWindow : Window
{
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