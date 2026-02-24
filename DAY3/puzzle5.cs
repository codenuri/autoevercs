using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

// puzzle Step #5. 생성자에 있는 Image Load 코드를 별도의 함수로 분리

class MainWindow : Window
{
    private int bw = 0;
    private int bh = 0;

    private const int COUNT = 5;

    private Grid grid;


    public void InitPanel()
    {
        // #1. Grid 생성
        grid = new Grid();

        // #2. Row, Col 설정 ( COUNT * COUNT)
        for (int i = 0; i < COUNT; i++)
        {
            grid.RowDefinitions.Add(new RowDefinition());
            grid.ColumnDefinitions.Add(new ColumnDefinition());
        }

        // #3. MainWindow 의 Content 로 grid 연결
        Content = grid;
    }

    public void MakeGridImage()
    {
        Uri uri = new Uri("C:\\totoro.jpg");
        BitmapImage bm = new BitmapImage(uri);

        bw = (int)(bm.Width / COUNT);
        bh = (int)(bm.Height / COUNT);

        Int32Rect rc = new Int32Rect(0, 0, bw, bh);

        CroppedBitmap cb = new CroppedBitmap(bm, rc);

        Image img = new Image();
        img.Source = cb;

        // 생성된 Image 객체를 Grid 0, 0 에 넣기
        Grid.SetRow(img, 0);
        Grid.SetColumn(img, 0);

        grid.Children.Add(img);
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