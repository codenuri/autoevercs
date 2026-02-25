// this1.cs   추가
using static System.Console;

class Point
{
    private int x = 0;
    private int y = 0;
    public Point(int a, int b) => (x, y) = (a, b);

    public void Set(int a, int b)
    {
        x = a; 
        y = b; 
    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);
        Point p2 = new Point(1, 2);

        p1.Set(10, 20); // 이 한줄의 정확한 원리는 생각해 봅시다
        p2.Set(10, 20); 

    }
}
