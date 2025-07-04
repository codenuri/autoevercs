using System.Windows;
using System.Windows.Media;

// 핵심 : 윈도우의 다양한 Event 처리하기

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        app.Startup += App_Startup;
        app.Exit += App_Exit;

        Window w = new Window();

        w.MouseRightButtonDown += OnRightDown;

        w.Show();

        app.Run();
    }

    private static void App_Exit(object sender, ExitEventArgs e)
    {
        Console.WriteLine("프로그램이 시작됩니다.");
    }

    private static void App_Startup(object sender, StartupEventArgs e)
    {
        Console.WriteLine("프로그램이 종료됩니다.");
    }

    private static void OnRightDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("RIGHT DOWN");
    }
}

