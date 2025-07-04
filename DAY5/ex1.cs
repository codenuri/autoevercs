// ex1.cs

// WPF 프로그램도 C# 코드 입니다.
// 결국 entry point 는 동일 합니다.

// 핵심 #1.
// WPF 프로그램을 사용하려면 프로젝트 설정에서 WPF 를 사용하겠다고 설정해야 합니다.
// => 현재 프로젝트는 콘솔이므로 WPF 설정 안되어 있습니다.

// 핵심 #2. console 프로젝트에서 WPF 사용하도록 환경 설정하는 방법
// => 교재 4page 참고

// 핵심 #3. 설정에서 <OutputType> 의미
// => Exe : console 창이 나타난다.
// => WinExe : console 창이 나타나지 않는다.



using System.Windows;

class Program
{
    public static void Main()
    {
        MessageBox.Show("Hello");
    }
}