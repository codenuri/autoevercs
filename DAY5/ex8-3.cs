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
