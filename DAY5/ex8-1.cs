// ex8-1
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// 핵심 : Layout(Panel) 개념
// => 여러개의 자식 컨트롤을 화면에 배치하는 책임을 지는 클래스
// => 1. Window 위에는 Layout 부착
// => 2. 다양한 자식 컨트롤은 Layout 에 "Layout객체.Children.Add(자식컨트롤)"
// => 3. 7 ~ 10 개 정도 종류가 있습니다.

class MainWindow : Window
{
    public MainWindow()
    {
        // #1. Layout(Panel)을 먼저 생성후 Window 에 Content로
        StackPanel sp = new StackPanel();
        
//      sp.Orientation = Orientation.Vertical;
        sp.Orientation = Orientation.Horizontal;

        this.Content = sp;

        // #2. 이제 다양한 컨트롤을 만들어서 stack panel 에 자식으로 부착
        Button btn1 = new Button();
        Button btn2 = new Button();

        btn1.Content = "button1";
        btn2.Content = "button2";

        // sp.Children : 패널의 자식컨트롤을 관리하는 List
        sp.Children.Add(btn1);
        sp.Children.Add(btn2);

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
