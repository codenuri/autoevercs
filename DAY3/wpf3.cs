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
        // 아래의 모든 속성은 "기반 클래스" 인 Window 로 부터 상속 받은것
        Title = "Hello";
        Width = 500;
        Height = 500;
        Content = "ABCD"; // 캡션바가 아닌 윈도우에 표현할 컨텐츠 연결

        Topmost = true;  // 항상위!!! 항상 다른 윈도우 위에 
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
