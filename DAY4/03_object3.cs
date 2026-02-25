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
        List<Rect> s = new List<Rect>(); // Rect 만 보관 가능

        // 모든 도형을 같이 보관하려면
        // #1. Object 타입으로 보관
        // => 단점 : Object 안에는 Draw() 가 없다. Object 타입으로 호출안됨
        // => 호출하려면 캐스팅 필요하고, 복잡해진다
        List<object> s1 = new List<object>();

        // #2. 모든 도형의 공통의 특징을 담은 Shape 만들고 Shape 타입으로 보관
        List<Shape> s2 = new List<Shape>();

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
