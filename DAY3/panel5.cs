// panel1.cs
using System.Windows;
using System.Windows.Controls;

// 프로그램을 배우는 것은 ?
// 1. 프로그래밍 언어(C#, C++, Java, Python 등) 문법
// 2. 해당 언어로 만들어진 라이브러리 사용법

// 라이브러리 사용시 대부분 지켜야 하는 규칙들이 있습니다.
// => Framework 라고 합니다. - 각 라이브러리는 자신만의 규칙이 있습니다.
// => WPF : Window Presentation Framework

// WPF 규칙중 한개
// => 윈도우에 여러개 자식컨트롤을 붙이려면 Panel 을 사용해야 한다.

class MainWindow : Window
{
    public MainWindow()
    {
        // Grid Panel : 엑셀처럼 격자형태로 관리하는 Panel
        Grid grid = new Grid(); 

        Content = grid;

        // #1. Row, Col 값 설정
        // grid.SetRowCol(2, 3); // 일반적인 라이브러리는 이렇게
        //                          2개 컬럼, 3개 Row

        // WPF 는 독특한 방법 사용
        grid.RowDefinitions.Add(new RowDefinition());
        grid.RowDefinitions.Add(new RowDefinition());

        grid.ColumnDefinitions.Add(new ColumnDefinition());
        grid.ColumnDefinitions.Add(new ColumnDefinition());


        // #2. 컨트롤을 만들고
        Button b1 = new Button { Content = "버튼1" };
        Button b2 = new Button { Content = "버튼2" };

        // #3. 각 컨트롤이 Grid 에 어디에 놓일지 설정(아직 부착은 아님)
        // => 이 부분이 WPF 라이브러리의 독특한 코드
        Grid.SetRow(b1, 0);
        Grid.SetColumn(b1, 0);

        Grid.SetRow(b2, 1);
        Grid.SetColumn(b2, 1);

        // #4. 마지막으로 컨트롤을 Grid 에 부착
        grid.Children.Add(b1);
        grid.Children.Add(b2);




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