// garbage.cs

class Point { }

// Garbage Collector
class Program
{
    public static void Main()
    {
        Point p1;
        {
            Point p2 = new Point();
            int n = 0;
        }
    }
}