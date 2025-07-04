// ex8-1
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;


// 가장 널리 사용되는 Layout
// => Grid 

class MainWindow : Window
{
    public MainWindow()
    {
        Button btn1 = new Button { Content = "button1" };
        Button btn2 = new Button { Content = "button2" };
        Button btn3 = new Button { Content = "button3" };
        Button btn4 = new Button { Content = "button4" };

        // #1. 생성하고  윈도우에 부착
        Grid grid = new Grid();

        this.Content = grid;

        // #2. Grid 의 row, coloum 지정하기
        // => 아래 처럼하지 않습니다.
        // => 아래 처럼하게 되면, 각 row 의 크기 등을 관리할수 없습니다.
        // grid.Row = 3;
        // grid.Column = 3;

        // Row, Column 자체가 하나의 객체입니다.
        RowDefinition r1 = new RowDefinition();
        RowDefinition r2 = new RowDefinition();
        RowDefinition r3 = new RowDefinition();
    
        ColumnDefinition c1 = new ColumnDefinition();
        ColumnDefinition c2 = new ColumnDefinition();
        ColumnDefinition c3 = new ColumnDefinition();

        grid.RowDefinitions.Add(r1);
        grid.RowDefinitions.Add(r2);
        grid.RowDefinitions.Add(r3);

        grid.ColumnDefinitions.Add(c1);
        grid.ColumnDefinitions.Add(c2);
        grid.ColumnDefinitions.Add(c3);


        // #3. 각 자식 컨트롤이 Grid의 어느 위치에 놓일지 설정
        // => 역시 독특한 방법입니다.
        // Grid 의 static method 사용..
        // => 이렇게 설계한 의도는 UI 를 XML 로 만들기 쉽게 하려고...(오후에)

        Grid.SetRow(btn1, 0);
        Grid.SetColumn(btn1, 0);

        Grid.SetRow(btn2, 0);
        Grid.SetColumn(btn2, 2);

        Grid.SetRow(btn3, 1);
        Grid.SetColumn(btn3, 1);

        Grid.SetRow(btn4, 2);
        Grid.SetColumn(btn4, 2);


        // #4. 자식컨트롤을 grid 에 추가
        grid.Children.Add(btn1);
        grid.Children.Add(btn2);
        grid.Children.Add(btn3);
        grid.Children.Add(btn4);
    }
}







class App : Application
{
    public App()
    {

    }

    [STAThread]
    public static void Main()
    {
        App app = new App();
        MainWindow w = new MainWindow();
        w.Show();
        app.Run();
    }
}
