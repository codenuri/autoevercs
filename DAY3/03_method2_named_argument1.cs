
class Rect
{
    public void Set(int x, int y, int width, int height) { }
}

class Program
{
    public static void Main()
    {
        Rect rc = new Rect();

        // 아래 처럼 코딩해 놓으면
        // 다른 개발자가 이코드를 읽을때
        // 인자의 의미가 명확하지 않을수 있습니다
        // 3번째 인자의 의미가 뭘까 ? width ? x2
        rc.Set(1, 1, 10, 10);

        // 아래 처럼 코딩해 놓으면 어떨까요 ?
        rc.Set(x:1, y:1, width:10, height:10);

        // 일부만 표기도 가능
        rc.Set(1, 1, width: 10, height: 10);

        // 이름이 있으면 순서 변경도 가능
        rc.Set(1, 1, height: 10, width: 10);

    }
}
