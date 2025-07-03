using System.Windows;
using System.Windows.Media;

// 핵심 : 윈도우의 다양한 Event 처리하기

class Program
{
    [STAThread]
    public static void Main()
    {
        Application app = new Application();

        Window w = new Window();

        w.MouseLeftButtonDown += OnLeftDown;


        w.Show();

        app.Run();
    }

    private static void OnLeftDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
    {
        Console.WriteLine("LButtonDown");
    }
}

// 1. 잘되신 분은 오른쪽 버튼 누를때 "메세지 박스" 나타나게 해 보세요

// 2. 윈쪽 버튼 관련 모든 코드 제거해 보세요