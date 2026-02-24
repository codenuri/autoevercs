using System.Windows;

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}