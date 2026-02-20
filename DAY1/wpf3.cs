using System.Windows;

// 핵심 
// => UI 를 만들경우, 바로 종료되게 하지 말고
// => event loop 수행

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();

        // 아래 2줄이 위에서 만든 윈도우에서 발생하는
        // 이벤트에 대한 기본 처리를 해주는 코드
        Application app = new Application();
        app.Run();  
    }
}
