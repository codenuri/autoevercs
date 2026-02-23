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
        string s1 = new string();
        Rect   r1 = new Rect();

        // 참고 : 파이썬
        // Rect r = Rect();

    }
}
