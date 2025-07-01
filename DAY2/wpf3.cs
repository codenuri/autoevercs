using System.Windows;

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();

        w.Show();

        // UI(window)를 생성한경우
        // 프로그램을 종료되지 않도록하게
        // UI 에서 발생하는 이벤트의 기본 처리를 제공 해야 합니다.
        // => Application 이라는 클래스가 제공
        Application app = new Application();
        app.Run();

    }
}
