using static System.Console;

// 핵심 #2.

class Rect
{
    public void Draw() { WriteLine("Draw Rect"); }
}

class Circle
{
    public void Draw() { WriteLine("Draw Circle"); }
}

class Program
{
    public static void Main()
    {
        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1)
            {
                Rect r = new Rect();
            }
            else if (cmd == 2)
            {
                Circle c = new Circle();
            }
        }
    }
}