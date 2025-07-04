using System.Windows;
using System.Windows.Media;

// 핵심 #1. WPF 의 핵심 객체 2개

// 1. Application 객체 : 프로그램의 시작/끝 등의 life cycle 에서 event 함수 등록
//                       event 루프 실행(app.Run())

// 2. Window 객체 : 주된 UI 윈도우 담당

// 핵심 #2. event 처리함수 등록하는 방법

// 핵심 #3. 아래 코드의 단점
// => 

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
        Console.WriteLine("프로그램이 종료됩니다.");
    }

    private static void App_Startup(object sender, StartupEventArgs e)
    {
        
        Console.WriteLine("프로그램이 시작됩니다.");
    }

    private static void OnRightDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        MessageBox.Show("RIGHT DOWN");
    }
}

