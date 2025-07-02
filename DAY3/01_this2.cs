// this 활용
// this 는 언제 사용하나요 ?

class Point
{
    private int x = 0;
    private int y = 0;

    public void Set(int x, int y)
    {
        // 아래 코드에서 x, y 는 모두 인자의 x의 입니다.
        // x = x;
        // y = y;

        // 필드와 인자가 이름 충돌시 
        // 필드임을 명확히 하려면 this 를 사용합니다.
        this.x = x;  // 여기서 this 는 결국 Main 에서 만든 "객체p" 와동일
        this.y = y;

        // 이름 충돌이 없더라도 "this.x" 방식으로 사용하면
        // => 이 코드는 지역변수가 아닌 필드 이다. 라고 명확히 할수 있습니다.
        // => 가독성 높은 좋은 코드
    }
    // 메소드가 this 를 반환하면 메소드 호출을 연속적으로 할수 있습니다.
    // => java 언어의 "빌더 패턴" 기술이 이 문법 사용
    public Point Foo()
    {
        // 메소드 안에서 this : Foo 를 호출할때 사용한 객체
        //                      즉, Main 메소드에서 만든 "객체 p"
        return this;
    }
}

class Program
{
    public static void Main()
    {
        Point p = new Point();
        p.Set(1, 2);

        p.Foo().Foo().Foo().Foo();
        // p
    }
}
