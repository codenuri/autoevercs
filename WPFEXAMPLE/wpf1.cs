
// DAY5 안의 WPFSAMPLE.cs 복사

using System.Windows;
using System.Windows.Media;

// step1. 콘솔 프로젝트에서 WPF 사용하기 위한 설정 알아두세요

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();

        Application app = new Application();
        app.Run();
    }
}