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
        x = x; 
        y = y; 

    }
}

class Program
{
    public static void Main()
    {
        Point p1 = new Point(1, 2);

        p1.Set(10, 20);    
  

    }
}
