using static System.Console;

// C#/C++/Java 등은 모두 객체지향 언어 입니다.

// 객체지향 언어의 핵심
// => 프로그램에서 필요한 타입을 먼저 만들고
// => 만들어진 타입을 사용해서 코드를 작성해라

// 타입을 만들때 사용하는 키워드 : class, struct 
class Rect
{
    // 사각형 한개를 표현할때 필요한 데이타
    // => 필드(field)라고 부릅니다.
    // => public 은 다음주에, 지금은 개념위주로 이해, 세부 문법은 월요일날
    public int left;       
    public int top; 
    public int right;
    public int bottom;

    // 사각형과 관련된 기능을 수행하는 함수를 만드세요
    // => 메소드(method)라고 부릅니다.
    public int GetArea()
    {
        // 이 안에서는 자신의 필드를 마음대로 접근 가능합니다.
        return (right - left) * (bottom - top);
    }
}

// Top-Level 방식
// => Main 없이, 소스 파일 1번째 줄부터 실행되는 방식
// => class 등의 문법을 사용할때 제약이 많습니다.
// => 그래서 실전에서는 Main 함수 만드는 방식으로

// 아래 클래스는 무조건 외우세요. 월요일에 자세한 문법 설명
class Program
{
    public static void Main()
    {
        // 이제 사각형이 필요하면 "Rect" 타입을 사용하면 됩니다.
        Rect rc = new Rect(); // new Rect(1,1,10,10)
        rc.left  = 1;
        rc.top   = 1;
        rc.right = 10;
        rc.bottom= 10;


        int area = rc.GetArea(); // 면적 구하기

    }
}

// C#/Java 에서 알아야 하는 것들

// 1. Rect 같은 타입(클래스)를 만들때 필요한 문법 - 어려운 과정

// 2. 미리 만들어진 타입(클래스, 표준라이브러리) 사용법
// => 사용법 자체는 쉽다
// => 그런데, 양이 많다 (수만개 클래스)