using System.Drawing;
using System.Windows;
using System.Windows.Media;

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();
        w.Title = "AAA";

        w.MouseLeftButtonDown += W_MouseLeftButtonDown;
        w.MouseRightButtonDown += W_MouseRightButtonDown;

       
        Application app = new Application();
        app.Run();
    }

    private static void W_MouseRightButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("Right 버튼 누름");
    }

    private static void W_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("왼쪽 버튼 누름");
    }
}   
