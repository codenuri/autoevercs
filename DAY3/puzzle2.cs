using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle Step #2. 그림의 전체가 아닌 일부분 출력

class MainWindow : Window
{
    public MainWindow()
    {
        Uri uri = new Uri("C:\\totoro.jpg"); 

        BitmapImage bm = new BitmapImage(uri);

        // Load된 비트맵에서 일부분을 Crop
        Int32Rect rc = new Int32Rect(0, 0, 100, 100);

        CroppedBitmap cb = new CroppedBitmap(bm, rc);


        Image img = new Image();
//      img.Source = bm; // 전체 그림과 연결
        img.Source = cb; // 일부와 연결



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