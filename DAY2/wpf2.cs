// wpf2.cs
using System.Windows;

class Program
{
    // GUI 프로그램은 Main 위에 아래 코드 필요 - 어려운 내용.
    // 항상 사용하므로 외우면됩니다.
    [STAThread]
    public static void Main()
    {
        Window w = new Window();

        w.Show();

//        MessageBox.Show("Hello");
    }
}
