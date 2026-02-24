using System.IO;
using System.Media;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// AI 가 만들어준 state 배열 섞는 코드 사용



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








    private Random random = new Random();

    public void ShuffleMove()
    {
        int shuffleCount = 1000;
        int emptyValue = 24;

        for (int i = 0; i < shuffleCount; i++)
        {
            int emptyRow = -1;
            int emptyCol = -1;

            // 빈칸 찾기
            for (int r = 0; r < 5 && emptyRow == -1; r++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (state[r, c] == emptyValue)
                    {
                        emptyRow = r;
                        emptyCol = c;
                        break;
                    }
                }
            }

            List<(int r, int c)> moves = new List<(int, int)>();

            if (emptyRow > 0) moves.Add((emptyRow - 1, emptyCol));
            if (emptyRow < 4) moves.Add((emptyRow + 1, emptyCol));
            if (emptyCol > 0) moves.Add((emptyRow, emptyCol - 1));
            if (emptyCol < 4) moves.Add((emptyRow, emptyCol + 1));

            var move = moves[random.Next(moves.Count)];

            state[emptyRow, emptyCol] = state[move.r, move.c];
            state[move.r, move.c] = emptyValue;
        }
    }

    protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
    {       
        base.OnMouseRightButtonDown(e);

        ShuffleMove(); // state 배열 섞기

        MakeGridImage(); // state 배열을 사용해서 Grid 배치
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