using System.Windows;

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        // 아래 코드가 전부 Property 를 사용하는 것
        // => p.Age = 10 과 같은 원리의 코드
        w.Title = "Hello";  
        w.Width = 300;
        w.Height = 300;

        w.Show();

        // UI 를 만든경우, 종료되지 말고 event loop 실행
        Application app = new Application();
        app.Run();
    }
}