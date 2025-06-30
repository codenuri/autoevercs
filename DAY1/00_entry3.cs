// Top-Level 방식의 원리(6 page)

// 아래 코드를
// System.Console.WriteLine("hello, C#");


// 컴파일러가 아래 처럼 변경한 것

class CompilerGeneratedName // <= 클래스 이름은 컴파일러가 임의로 결정
{
    public static void Main()
    {
        // 이 위치에 사용자가 만든 코드를 넣게 됩니다.
        System.Console.WriteLine("hello, C#");
    }
}
