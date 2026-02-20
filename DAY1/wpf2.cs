// wpf2.cs
// 핵심 : 직접 Window 만들기
// => 지금 단계 부터는 Top-Level 안됩니다.
// => Main 메소드 만드는 방식

using System.Windows;

class Program
{
    // GUI 를 만든경우 Main 위에 반드시 아래 한줄 필요(관례적인 코드)
    [STAThread]
    public static void Main()
    {
        Window w = new Window();
        w.Show();

//      MessageBox.Show("Hello");

        // 그런데, 이경우, 프로그램은 즉시 종료 되므로 윈도우 바로 파괴!!
    }
}
