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
        // new 이야기
        // 핵심 : C#의 모든 변수는 "new" 로 만들어야 합니다.
        int    n1 = new int();
        double d1 = new double();
        string s1 = new string("AAA");
        Rect   r1 = new Rect();

        // 참고 : 파이썬
        // Rect r = Rect();

        // primitive type(언어 자체가 제공하는 타입) 은
        // 변수 생성시 "new 를 사용하지 않은 단축 표기법"을 제공
        // => 목표 : 다른 언어와 동일하게 사용하게 하기 위해
        int n2 = 0;
        double d2 = 3.4;
        string s2 = "AAA";

        // 단, 사용자 타입은 반드시 new 사용

    }
}
