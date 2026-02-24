using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle Step #1. 그림 Load해서 윈도우에 연결

class MainWindow : Window
{
    public MainWindow() 
    {
        // #1. 자원의 경로를 관리하는 객체 생성
        // => Uniform Resource Identity
        Uri uri = new Uri("C:\\totoro.jpg"); // 그림 경로 

        // #2. 그림(Bitmap) 을 Load 하는 객체 생성
        BitmapImage bm = new BitmapImage(uri);


        // #3. Load 된 그림을 Content 로 연결 또는 panel 의 자식으로 넣으려면
        // => Image 타입의 객체가 필요
        Image img = new Image();
        img.Source = bm;

        // #4. Content 에 Imae 객체 연결
        Content = img;
    
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