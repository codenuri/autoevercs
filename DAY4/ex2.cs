using System.Windows;
using System.Windows.Media;

// 핵심 : Window 창 만들기
// 1. Main 에서 GUI 를 생성하는 경우 함수 앞에 반드시
//    [STAThread] 적어야 한다. - 관례적인 코드 무조건 위우세요

// 2. Window 라는 클래스 사용

class Program
{
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Title = "Hello";
        w.Width = 300;
        w.Height = 300;
        w.Background = new SolidColorBrush(Colors.Yellow);

        w.Show();


        MessageBox.Show("Hello");
    }
}