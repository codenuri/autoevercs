using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

/*
class Window
{
    // Title, Width, Content 등의 다양한 Property 제공
}
*/

class MainWindow : Window
{
    public MainWindow()
    {
        Title = "Hello";

        // 가장 중요한 Property : Content
        // => 윈도우 위에 나타낼 한개의 컨텐츠를 연결 가능
        // Content = "ABCD";        // 문자열도 되고
        // Content = new Button { };   // 다양한 컨트롤및 그림도 가능
        
        // 그런데, Content 에는 한개만 연결가능
        // 여러개 자식 컨트롤을 만들려면
        // => 여러개의 컨트롤을 관리하는 Panel 이라는 도구를 연결
        StackPanel sp = new StackPanel();

        Content = sp; // 윈도우 위에 StackPanel 을 붙인것
                      // Panel 자체는 투명해서 눈에 보이지는 않습니다


        // 이제 다양한 컨트롤을 Panel 에 붙이면 됩니다.
        Button b1 = new Button { Content = "버튼1", FontSize = 32 };

        sp.Children.Add(b1);

        Slider slider = new Slider();   
        sp.Children.Add(slider);

        RadioButton radio = new RadioButton();
        sp.Children.Add(radio);

        // 실행해보고 잘되신분은 버튼한개 더 추가해 보세요
        sp.Children.Add( new Button { Content = "버튼2" } );
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
