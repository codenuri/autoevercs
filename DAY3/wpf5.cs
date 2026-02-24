using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

/*
class Window
{
    // Title, Width, Content 등의 다양한 Property 제공
}

class Button {}
class Slider {}

// StackPanel 에 대해서 생각해 봅시다.
class StackPanel 
{
    // 여러개의 컨트롤을 관리해야 합니다.
    public List<?> Children = new List<?>();

}





*/

class MainWindow : Window
{
    public MainWindow()
    {
        Title = "Hello";

        StackPanel sp = new StackPanel();

        Content = sp; 
        Button b1 = new Button { Content = "버튼1", FontSize = 32 };

        sp.Children.Add(b1);

        Slider slider = new Slider();
        sp.Children.Add(slider);

        RadioButton radio = new RadioButton();
        sp.Children.Add(radio);
        sp.Children.Add(new Button { Content = "버튼2" });
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
