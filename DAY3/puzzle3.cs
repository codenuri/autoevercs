using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle Step #3. 정확한 크기 계산

class MainWindow : Window
{
    // 한개 블럭의 너비, 높이
    private int bw = 0; // block width
    private int bh = 0; // block height

    // 블럭의 갯수, 5 가 아닌 다른 것으로 하려면 COUNT 초기값 변경
    private const int COUNT = 5; // 상수

    public MainWindow()
    {
        Uri uri = new Uri("C:\\totoro.jpg");
        BitmapImage bm = new BitmapImage(uri);

        bw = (int)(bm.Width / COUNT);
        bh = (int)(bm.Height / COUNT); 



        // Load된 비트맵에서 일부분을 Crop
        // 인자는 x, y, w, h 의미
        Int32Rect rc = new Int32Rect(0, 0, bw, bh);


        CroppedBitmap cb = new CroppedBitmap(bm, rc);


        Image img = new Image();
        img.Source = cb; 



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