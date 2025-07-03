using static System.Console;


// 추상 클래스 : 지켜야 하는 규칙(추상메소드) + 다른 멤버도 같이 제공
// 인터 페이스 : 지켜야 하는 규칙 만 가진 것

/*
abstract class Shape
{
    public int color = 0;

    public abstract void Draw();
}
*/

// 메소드의 선언 모양만 넣을수 있다.
// => 메소드 구현부, 필드등은 넣을수 없다.
// => public, abstract 등도 표기 하지 않음.
// => 오직 메소드 선언(반환타입, 이름, 인자)만 표기

interface Shape
{
    void Draw();
}

// 인터페이스 상속 받는 클래스는 반드시 약속된 함수 만들어야 합니다.
// 만들지 않으면 컴파일 에러!!
// => 만들때 override 표기 하지 않습니다.


class Rect : Shape
{
    public void Draw() { WriteLine("Draw Rect"); }
}

class Program
{
    public static void Main()
    {
        Shape s = new Rect();
        s.Draw();
    }
}
