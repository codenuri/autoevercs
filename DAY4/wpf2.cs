using System.Windows;
using System.Windows.Controls;

class MainWindow : Window
{
    private Button btn1 = null;
    private Button btn2 = null;
    private TextBox tb = null;
    private Slider sd = null;

    public MainWindow()
    {
        StackPanel sp = new StackPanel();
        this.Content = sp;   // this 없어도 됩니다.        
        //-------------------------------

        // 자식 컨트롤 만들어서 패널에 부착
        btn1 = new Button { Content = "Ok1" };
        btn2 = new Button { Content = "Ok2" };
        tb = new TextBox { Width = 100, Height = 50 };
        sd = new Slider();

        sp.Children.Add(tb);
        sp.Children.Add(btn1);
        sp.Children.Add(sd);
        sp.Children.Add(btn2);
        //--------------------------------
        // 자식 컨트롤에서 나오는 event 를 처리하기 위해서
        // 컨트롤에 함수 등록
        btn1.Click += Btn1_Click;       // DAY4. event3.cs 와 동일원리

    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        // TextBox(tb) 에 입력된 문자열을 꺼내서
        string s = tb.Text;

        this.Title = s; // 윈도우 캡션바로 설정(this 없어도 됨)
    }
}


class Program
{
    [STAThread]
    public static void Main()
    {
        MainWindow w = new MainWindow();
        Application app = new Application();

        w.Show();
        app.Run();
    }

}
