// 03_object3.cs

class Rect
{
    public void Draw() { }
}
class Circle
{
    public void Draw() { }
}

class Program
{
    public static void Main()
    {
        List<Rect> s = new List<Rect>();

    }

    public static void PrintHierachy(object obj)
    {
        Type t = obj.GetType();

        while (true)
        {
            Console.Write("{0} ->", t.Name);

            if (t.Name == "Object") break;

            t = t.BaseType;
        }

        Console.WriteLine(""); // 개행
    }
}
