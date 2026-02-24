using System.IO;
using System.Media;
using System.Printing;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// puzzle Step #10. 블럭이동
// => 마무리 단계

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

        Point pt = e.GetPosition(grid); // grid 를 기준으로 좌표 얻기

        int bx = (int)(pt.X / (grid.ActualWidth / COUNT));
        int by = (int)(pt.Y / (grid.ActualHeight / COUNT));

       if (bx < 0 || bx >= COUNT || by < 0 || by >= COUNT)
            return;

       // bx, by : 사용자가 클릭한 위치가 Grid 의 몇번째 블럭인가에 대한 정보

        if ( bx > 0 && state[by, bx-1] == EMPTY) // 왼쪽 조사
        {
             MoveBlock(bx, by, bx-1, by); // (bx, by) 의 image 를 (bx-1, by)로이동
        }
        else if (bx < COUNT-1 && state[by, bx + 1] == EMPTY) // 오른쪽 조사
        {
            MoveBlock(bx, by, bx + 1, by); 
        }
        else if (by > 0 && state[by-1, bx] == EMPTY) // 위조사
        {
            MoveBlock(bx, by, bx, by-1);
        }
        else if (by < COUNT-1 && state[by + 1, bx] == EMPTY) // 아래조사
        {
            MoveBlock(bx, by, bx, by + 1);
        }
        else
        {
            // 4방향 모두 이동할수 없다면 "삑"
            SystemSounds.Beep.Play();
            return;
        }

        // 블럭이 이동되었다면 "다맞추었는지 확인 해야 한다"
        // IsComplete(); // 복습시 이함수 만들어 보세요
    }

    public void MoveBlock(int x, int y, int tx, int ty)
    {
        // #1. Grid 의 x,y 위치에 있는 image 객체의 참조 얻기
        //      var img = grid.GetChild(x, y); // 이런 메소드가 없습니다.

        // Grid 의 모든 자식을 순회 하면서 조사할수 밖에 없습니다.
        // => 이부분이 Grid 의 단점
        Image img;
        
        foreach( var e in grid.Children )
        {
            if (Grid.GetRow(e) == y && Grid.GetColumn(e) == x)
                img = (Image)e;
        }

        // #2. image 객체의 Grid 위치 속성을 tx, ty 로 변경
        Grid.SetRow(img, ty);
        Grid.SetColumn(img, tx);
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