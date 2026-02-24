using System.IO;
using System.Media;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// 복습시 과제
// 1. 다맞추었는지 확인하는 IsComplete() 만들어 보세요
// => 다 맞춘 경우 MessageBox 나타내 보세요

// 2. 마우스 오른쪽 버튼 누르면 게임판 섞어 보세요
// => state[] 2차원 배열만 섞으면 됩니다.
// => 그런데, 맞출수 있게 섞어야 합니다



class MainWindow : Window
{
    private int bw = 0;
    private int bh = 0;

    private const int COUNT = 5; // 여기만 변경하면 블럭 갯수 변경됩니다.
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
                if (state[y, x] != EMPTY)
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

        Point pt = e.GetPosition(grid); 

        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));

        if (bx < 0 || bx >= COUNT || by < 0 || by >= COUNT)
            return;


        if (bx > 0 && state[by, bx - 1] == EMPTY) 
        {
            MoveBlock(bx, by, bx - 1, by); 
        }
        else if (bx < COUNT - 1 && state[by, bx + 1] == EMPTY) 
        {
            MoveBlock(bx, by, bx + 1, by);
        }
        else if (by > 0 && state[by - 1, bx] == EMPTY) 
        {
            MoveBlock(bx, by, bx, by - 1);
        }
        else if (by < COUNT - 1 && state[by + 1, bx] == EMPTY) 
        {
            MoveBlock(bx, by, bx, by + 1);
        }
        else
        {
            SystemSounds.Beep.Play();
            return;
        }

    }

    public void MoveBlock(int x, int y, int tx, int ty)
    {

        Image img = null;

        foreach (var e in grid.Children)
        {
            Image i = (Image)e;
            if (Grid.GetRow(i) == y && Grid.GetColumn(i) == x)
                img = (Image)e;
        }

        Grid.SetRow(img, ty);
        Grid.SetColumn(img, tx);

        int tmp = state[y, x];
        state[y, x] = state[ty, tx];
        state[ty, tx] = tmp;
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