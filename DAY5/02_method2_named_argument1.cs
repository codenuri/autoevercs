
class Rect
{
    public void Set(int x, int y, int width, int height) { }
}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect();

        // 아래 한줄만 보고, 인자 4개의 의미를 예측해 보세요
        // => x,  y,  width, height 
        // => x1, y1, x2,    y2
        // 즉, 도움말이 필요 할수 있습니다
        rc.Set(1, 1, 10, 10);


        // 아래 처럼하면 어떨까요 ?
        // => named argument 라는 문법
        // => C#, Objective-C, Swift 등의 언어가 지원하는 문법
        rc.Set(x:1, y:1, width:10, height:10);

        // 이름이 있다면 순서 변경가능
        rc.Set( width: 10, height: 10, x: 1, y: 1);

        // 위치와 이름 인자를 섞어도 가능
        rc.Set(1, 1, width: 10, height: 10);

        // 실전에서 많이 사용하지는 않습니다.
    }
}
