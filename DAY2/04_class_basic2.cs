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

    // 생성자 : 클래스 이름과 동일한 이름의 메소드
    //          변수를 생성하면 자동으로 호출된다.
    public Rect(int x1, int y1, int x2, int y2)
    {
        left = x1;
        top = y1;   
        right = x2;
        bottom = y2;
    }
}
class Program
{
    public static void Main()
    {
        Rect rc = new Rect(1, 1, 10, 10); // 이 순간 자동으로 생성자 호출

        int ret = rc.GetArea();

        Console.WriteLine($"{ret}");
    }
}