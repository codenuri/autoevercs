// 정리.cs  - 9-3.cs 복사하세요
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;

// WPF ( Windows Presentation Framework )
// => GUI 프로그램을 개발하기 위한 C# 클래스 라이브러리 

// 핵심 #1.
// 1. UI 는 XML(.Xaml) 로 개발 하고
// 2. UI 에 대한 이벤트 처리등의 코드만 C# 으로 작성하자
// => 당연히 C# 만으로도 모든 개발 가능.


// 하나의 윈도우(창)은 2개의 파일로 구성됩니다.
// UI를 책임지는          .XAML
// 이벤트처리등을 담당하는 .cs
//---------------------------------------------------
// 현재 소스 안에는 2개의 클래스 코드가 있습니다.
// => MainWindow, App 

// 그런데, 각각 클래스를 다른 파일로 작성하는 것이 편리합니다.
// => MainWindow.cs
// => App.cs
//----------------------------------------------------

// WPF 프로그램은 아래 2개의 객체를 생성
// => Window
// => App

// 또한, Window 객체 뿐 아니라 App 객체도 XAML 로 만들면
// => 다양한 App 속성을 C# 코드가 아닌 XAML 로 설정 가능.



// Wizard 가 생성하는 4개의 파일
// MainWindow.xaml : window 창에 대한 XML(ex9-3.xaml 과 동일)
// MainWindow.cs   : window 창에 대한 event 처리를 담당 - MainWindow 클래스

// App.xaml : App 객체 생성
// App.cs   : App 에 대한 이벤트 처리를 담당하는 C# 코드


class MainWindow : Window
{
    public void InitializeComponent()
    {
    }

    public MainWindow()
    {
        InitializeComponent();

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

        

        FileStream fs = new FileStream("../../../ex9-3.xaml", FileMode.Open);
        Window w = (Window)XamlReader.Load(fs);

        w.Show();
        app.Run();
    }
}

