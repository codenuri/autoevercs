using System.Windows;
using System.Windows.Media;

// step3. Main 함수를 App 안으로

// => 이제 프로그램은 2개의 클래스로 구성됨

class MainWindow : Window
{

}

class App : Application
{
    [STAThread]
    public static void Main()
    {
        MainWindow w = new MainWindow();
        w.Show();

        App app = new App();
        app.Run();
    }
}
