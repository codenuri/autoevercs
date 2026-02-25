class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public void Set(int a, int b)   // void Set(Point this, int a, int b)
    {                               // {
        x = a;                      //      this.x = a;
        y = b;                      //      this.y = b;

    }

    public static void Foo(int a, int b) // void Foo(int a, int b))
    {
  //      this.x = 10; // error. static method 는 this가 추가안됨
    }
}
class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        
        p1.Set(10, 20);     // Set(p1, 10, 20)
        Point.Foo(1, 2);    // Foo(10, 20)

    }
}

// instance method : this 추가 됨
// static  method : this 추가 안됨

// Main 메소드는 static
// => 즉, Program 객체를 만들지 않고 호출된것
// => Main 안에서 this 는 없다!!!
// => 객체가 필요하면 만들어야 한다