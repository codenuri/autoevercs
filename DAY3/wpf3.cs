using System.Windows;
using System.Windows.Input;

/*

class Window
{

}
*/

class MainWindow : Window
{
    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        MessageBox.Show("LBUTTONDOWN");

        // base: 기반 클래스 를 의미
        // 기반 클래스의 함수도 실행되도록하기 위해 자동생성된 코드
        base.OnMouseLeftButtonDown(e);
    }

    protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
    {
        MessageBox.Show("RBUTTONDOWN");
        base.OnMouseRightButtonDown(e);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
        MessageBox.Show("KEYDOWN");
        base.OnKeyDown(e);
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
