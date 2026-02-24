using System.Windows;

/*
// C# WPF 내부에 아래 코드가 있습니다.
class Window
{
    // 다양한 필드와 메소드, Property 들

    // 윈도우 위에서 어떤 이벤트가 발생되면
    // 자동으로 호출되는 약속된 virtual 메소드
    virtual void OnMouseLeftButtuonDown(...) { }
    virtual void OnMouseRightButtuonDown(...) { }
    // 이외에 수십개의 virtual 메소드
}
*/
// WPF 일반적인 코딩 관례
// => Window 라는 클래스를 직접 사용하는 것이 아니라
// => Window 의 파생 클래스를 만들어서 사용
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