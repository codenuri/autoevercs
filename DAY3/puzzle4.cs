using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle Step #4. Grid 도입

class MainWindow : Window
{
    private int bw = 0; 
    private int bh = 0; 

    private const int COUNT = 5; 

    public MainWindow()
    {
        Uri uri = new Uri("C:\\totoro.jpg");
        BitmapImage bm = new BitmapImage(uri);

        bw = (int)(bm.Width / COUNT);
        bh = (int)(bm.Height / COUNT);


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