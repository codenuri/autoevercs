using System.IO;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// puzzle Step #9. 블럭 이동하기


class MainWindow : Window
{
    private int bw = 0;
    private int bh = 0;

    private const int COUNT = 5;
    private const int EMPTY = COUNT * COUNT - 1;

    private Grid grid;

    private int[,] state = new int[COUNT, COUNT];

    public void InitState()
    {
        for (int y = 0; y < COUNT; y++)
        {
            for (int x = 0; x < COUNT; x++)
            {
                state[y, x] = y * COUNT + x;
            }
        }

    }

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
                if ( state[y, x] != EMPTY )
                {
                    int bno = state[y, x];

                    int bx = bno % COUNT; 
                    int by = bno / COUNT; 

                    Int32Rect rc = new Int32Rect(bx * bw, by * bh, bw, bh);

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
    }

    protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
    {
        base.OnMouseLeftButtonDown(e);

        // 클릭 된 곳의 좌표를 grid 기반으로 얻기
//      Point pt = e.GetPosition(this); // this : 자신을 의미.
                                        // 즉, 윈도우를 기준으로 좌표 얻기
        Point pt = e.GetPosition(grid); // grid 를 기준으로 좌표 얻기

        // 좌표를 가지고 몇번째 블럭을 클릭했는지 알아야 한다.
        // => 좌표  / 한 블럭의 크기
        // => 여기서 한블럭은 그림의 크기가 아닌 grid 의 한블럭 크기
        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));

        Console.WriteLine("{0}, {1} 블럭 클릭", bx, by);

    }




    public MainWindow()
    {
        InitState();

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