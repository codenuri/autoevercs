using System.Windows;
using System.Windows.Media.Imaging;

// puzzle Step #1. 그림 Load해서 윈도우에 연결

class MainWindow : Window
{
    public MainWindow() 
    {
        // #1. 자원의 경로를 관리하는 객체 생성
        Uri uri = new Uri("C:\\totoro.jpg"); // 그림 경로 

        // #2. 그림(Bitmap) 을 Load 하는 객체 생성
        BitmapImage bm = new BitmapImage(uri);


        // #4. Content 에 연결
        Content = bm;
    
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