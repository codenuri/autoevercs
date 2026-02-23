using static System.Console;

class Rect
{
    public int left = 0;
    public int top = 0;
    public int right = 0;
    public int bottom = 0;

    public int GetArea()
    {
        return (right - left) * (bottom - top);
    }

    public Rect(int x1, int y1, int x2, int y2)
        => (left, top, right, bottom) = (x1, y1, x2, y2);

    public Rect() { }
}
class Program
{
    public static void Main()
    {
        // 핵심 : 용어
        int n = 10;
        n = 20;         // n 은 "변" 하는 "수" 입니다.
                        // 그래서 이름이 "변수(variable)"

        Rect rc = new Rect(1, 1, 10, 10);   

        // rc : "변하는 수" 보다는 "사각형 한개를 표현" 하고 있습니다.
        //      "객체(object)" 라고 표현합니다.

        // 객체 : 세상에 존재하는 모든 사물(책상, 의자, 자동차등..)
        //        rc 는 메모리에 존재하는 사각형 한개!!

        // n 도  "객체" 라고 표현해도 틀리지 않습니다.

        // 일반적인 관례(C++, C#, Java)
        // 언어 자체가 제공하는 타입(primitive type, int, double)을 메모리에 만든것 : 변수
        // class(struct) 문법으로 만든 타입의 변수를 메모리에 만든것 : 객체

        // Rust : 모든 것을 변수 라고 부름
        
    }
}

// Window w = new Window()   : w 는 윈도우 객체