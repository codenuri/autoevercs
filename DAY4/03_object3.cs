// 03_object3.cs
class Program
{
    public static void Main()
    {
        int n = 10;
        double d = 3.14;

        PrintHierachy(n);
        PrintHierachy(d);
        PrintHierachy("A");
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
