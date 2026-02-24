using System.IO;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// puzzle Step #7. 지금까지 코드 정리
// => UI 출력 완성

class MainWindow : Window
{
    private int bw = 0;
    private int bh = 0;

    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;

    private Grid grid;


    public void InitPanel()
    {
        grid = new Grid();

        for (int i = 0; i < COUNT; i++)
        {
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }
        Content = grid;
    }

    public void MakeGridImage()
    {
        Uri uri = new Uri("C:\\totoro.jpg");
        BitmapImage bm = new BitmapImage(uri);

        bw = (int)((int)bm.PixelWidth / COUNT);
        bh = (int)((int)bm.PixelHeight / COUNT);


        for (int y = 0; y < COUNT; y++)
        {
            for (int x = 0; x < COUNT; x++)
            {
                Int32Rect rc = new Int32Rect(x * bw, y * bh, bw, bh); // <= 핵심

                CroppedBitmap cb = new CroppedBitmap(bm, rc);

                Image img = new Image();
                img.Source = cb;
                img.Stretch = Stretch.Fill;
                img.Margin = new Thickness(0.5);


                Grid.SetRow(img, y);
                Grid.SetColumn(img, x);

                grid.Children.Add(img);
            }
        }


    }

    public MainWindow()
    {
        InitPanel();

        MakeGridImage();
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