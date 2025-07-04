// ex8-1
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;


// ex9-2.xaml 추가 (발음은 자멜, 자믈)
// 속성 에서 빌드없음


class MainWindow : Window
{
    // 아래 코드는 버튼의 참조만 만든것, 버튼 자체를 만든것은 아닙니다.
    private Button btn1 = null;
    private Button btn2 = null;
    private Button btn3 = null;
    private Button btn4 = null;

    public void InitializeComponent()
    {
        // XAML 을 Load 등의 UI 초기화 책임.
        FileStream fs = new FileStream("../../../ex9-2.xaml", FileMode.Open);
        StackPanel sp = (StackPanel)XamlReader.Load(fs);
        fs.Close();
        this.Content = sp;

        btn1 = (Button)sp.FindName("button1");
        btn2 = (Button)sp.FindName("button2");
        btn3 = (Button)sp.FindName("button3");
        btn4 = (Button)sp.FindName("button4");
    }

    public MainWindow()
    {
        InitializeComponent();

        // 버튼을 누를때 이벤트 처리하려면
        // "Click" 이벤트에 메소드 등록하면 됩니다.
        btn1.Click += Btn1_Click;
    }

    private void Btn1_Click(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("button1 click");
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

