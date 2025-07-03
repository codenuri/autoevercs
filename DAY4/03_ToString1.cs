// 기존에 있는 "03_ToString.cs" 를 "03_ToString2.cs" 로 변경하고

// "03_ToString1.cs" 추가해 보세요

class Program
{
    public static void Main()
    {
        int n = 10;
        double d = 3.4;

        // 어떤 값(10, 3.4등)을 화면에 출력하려면
        // => 결국 문자열로 변경해서 출력해야 합니다.
        // => 10 => "10"

        // C# 은 "변수가 가진 데이타를 문자열로 변경" 하는
        // ToString() 메소드 제공합니다.
        string s1 = n.ToString(); // "10"
        string s2 = d.ToString(); // "3.4"

        Console.WriteLine(n);
        
    }
}
/*
class Console
{
    public static void WriteLine( int data)
    {
        string s = data.ToString();
        // 이제 화면 출력하는 내부 함수로 s 출력
    }
}
*/





