using static System.Console;

// 객체지향 프로그래밍의 핵심
// => 프로그램에서 필요한 타입을 먼저 설계해라!!!
// => 대부분의 언어는 타입을 만드는 class 문법 제공

class Rect
{
    int x1 = 0;
    int y1 = 0;
    int x2 = 0;
    int y2 = 0;

    public int GetArea()
    {
        return (x2 - x1) * (y2 - y1);
    }

    // 생성자 : 클래스 이름과 동일한 함수(메소드)
    //          변수를 생성할때 자동으로 호출된다.
    //          데이타(field)초기화를 위해 사용
    //          반환 타입도 표기 하지 않습니다.
    public Rect(int a, int b, int c, int d)
    {
//        x1 = a;
//        y1 = b;
//        x2 = c;
//        y2 = d;

        // 위 4줄과 아래 한줄은 동일합니다.
        // => tuple deconstruction
        (x1, y1, x2, y2) = (a, b, c, d);
    }
}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect(1, 1, 10, 10);
        int ret = rc.GetArea();

        Console.WriteLine($"{ret}"); 
    }
}