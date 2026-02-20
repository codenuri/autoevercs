// C# 언어
// 소스 코드 확장자 : .cs    
// 파일 포맷        : UTF-8 권장, 다른 포맷도 가능
// 소스 스타일 : C/C++ 과 유사, 문장의 끝에는 반드시 세미콜론(;) 필요
//              대소문자 구별됨

// entry point 는 2가지 방식 제공
// 1. 클래스를 한개 만들고 Main 이라는 static 메소드 제공
//    (클래스, static 의 의미를 3일차 배우게 됩니다. 지금은 외우세요)
// => C#1.0 부터 사용되던 전통적인 방식

// 2. Top-Level Programming 방식(파이썬과 동일)
// => C#9.0 부터 지원
// => 소스 파일의 1번째 문장 부터 실행

// 아래 코드는 1번 방식
class Program
{
    public static void Main()
    {
        System.Console.WriteLine("hello, C#");
    }
}