using static System.Console;

// 핵심 #8. virtual vs non-virtual 

// Shape 메소드 중에서
// => 파생 클래스가 다시 만들게 되면 : virtual method 로
// => 파생 클래스가 다시 만들필요 없으면 : non-virtual 로
//                                      virtual 로 해도 되지만
//                                      (virtual 은 오버헤드가 있습니다.)


class Shape
{
    private int color = 0;

    // 아래 메소드는 virtual 로 할까요 ? non-virtual 로 할까요 ?
    // 아래 메소드는 파생 클래스가 다시 만들이유가 없습니다.
    // => non-virtual
    // => virtual 로 해도 문제 없지만, virtual 은 성능 저하가 있습니다.
    public void SetColor(int c) {  color = c; }

    // 도형의 면적을 구하는 방법은 "각 도형" 마다 다릅니다.
    // => 즉, 아래 메소드는 파생 클래스가 override 하게 되고
    // => 이때, override 된 메소드가 불리게 하려면 virtual
   public virtual int GetArea() { return 0; }


    public virtual void Draw() { WriteLine("Draw Shape"); }
        
    public virtual Shape Clone()
    {
        Shape s = new Shape();
        s.color = color; 
        return s;
    }
}



class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }

    public override Shape Clone()
    {
        return new Rect();
    }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("Draw Circle"); }

    public override Shape Clone()
    {
        return new Circle();
    }
}


class Program
{
    public static void Main()
    {
        List<Shape> s = new List<Shape>();

        while (true)
        {
            int cmd = int.Parse(Console.ReadLine());

            if (cmd == 1)
            {
                s.Add(new Rect());
            }
            else if (cmd == 2)
            {
                s.Add(new Circle());
            }
            else if (cmd == 9)
            {
                foreach (var e in s)
                {
                    e.Draw();
                }
            }
            else if (cmd == 8)
            {
                Console.Write("몇번째 만들었던 도형을 복제할까요 >> ");
                int k = int.Parse(Console.ReadLine());

                s.Add(s[k].Clone());  

            }
        }
    }
}


