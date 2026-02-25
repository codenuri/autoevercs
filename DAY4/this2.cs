// this1.cs   추가
using System.ComponentModel;
using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    // 사용자 코드                
    public void Set(int x, int y)
    {           
        // 필드와 인자의 이름이 동일하면 가까운 것 사용
        // => 아래 코드는 인자의 x, y
        //x = x; 
        //y = y;

        // this 활용 #1. 이름 충돌이 있을때 필드임을 나타내기 위해
        // => 이름 충돌이 없어도, "this.x" 로 사용하면
        //    필드임을 명확히 표현할수 있으므로 가독성 증가
        this.x = x;
        this.y = y;
    }

    // 활용 #2. this 를 반환하면 method 를 연속으로 호출가능
    public Point SetX(int x)
    {
        this.x = x;
        return this;
    }
    public Point SetY(int y)
    {
        this.y = y;
        return this;
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);

        p1.Set(10, 20);

        // 아래 같이 메소드를 연속으로 호출하면서 상태를 변경하는 기술이
        // JAVA 에서 아주 널리 사용됩니다
        // Java 용어중 "빌더" 라는 기술
        p1.SetX(10).SetY(20).SetX(5);

        // 다른 언어는 "method chaining" 이라고도 합니다.
        // => Rust 에서 널리 사용
  

    }
}
