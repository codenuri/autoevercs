// console
// property.cs

class Point
{
    /*
    private int x = 0;
    public int X
    {
        set { x = value; }
        get { return x; }   
    }
    */
    // 위 코드 처럼 "추가 작업" 이 없는 property 는 아래 처럼 만들면 됩니다.
    // 아래 코드는 위코드와 완전히 동일
    // => "auto implemented property"
    public int X { get; set; } = 0;

    // 그냥, public 필드 하면 안되나요 ?
    public int X = 0;
}

class Program
{
    public static void Main()
    {
        Point pt = new Point();
        pt.X = 10;
    }
}