using System.Windows;
using System.Windows.Controls;

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window { Title="Hello", Width=300, Height=300 };

        Button b = new Button { Content = "확인", FontSize = 120 };

        w.Content = b;

        w.Show();

        // UI 를 만든경우, 종료되지 말고 event loop 실행
        Application app = new Application();
        app.Run();
    }
}
