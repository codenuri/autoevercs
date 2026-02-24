using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle Step #6. 25 개 Grid 모두 채우기 - UI 완성
// => EMPTY 상수 도입
// => MakeGridImage() 함수만 변경됨

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

        bw = (int)(bm.Width / COUNT);
        bh = (int)(bm.Height / COUNT);

        // 한개의 블럭만 Grid 에 연결하는 코드
        /*
        Int32Rect rc = new Int32Rect(0, 0, bw, bh);
        CroppedBitmap cb = new CroppedBitmap(bm, rc);

        Image img = new Image();
        img.Source = cb;

        Grid.SetRow(img, 0);
        Grid.SetColumn(img, 0);

        grid.Children.Add(img);
        */

        for (int y = 0; y < COUNT; y++)
        {
            for (int x = 0; x < COUNT; x++)
            {
                Int32Rect rc = new Int32Rect(0, 0, bw, bh);
                CroppedBitmap cb = new CroppedBitmap(bm, rc);

                Image img = new Image();
                img.Source = cb;

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