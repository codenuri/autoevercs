using System.Windows;
using System.Windows.Input;

/*
class Window
{
    // Title, Width, Content 등의 다양한 Property 제공
}
*/

class MainWindow : Window
{
    // 생성자 : 객체가 생성될때 자동으로 호출되는 함수
    //          여기서 윈도우 GUI 관련 초기화 코드를 작성하면됩니다.
    public MainWindow()
    {
        Title = "Hello";
        Width = 500;
        Height = 500;
        Content = "ABCD";
    }
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
