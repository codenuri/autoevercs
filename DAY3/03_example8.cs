using static System.Console;

// 핵심 #9. abstract

// abstract method 가 한개 이상 있다면
// 클래스 자체도 abstract 가 되어야 합니다.
abstract class Shape
{
    private int color = 0;

    public void SetColor(int c) { color = c; }



    // 가상 메소드 : 기반 클래스가 기본 구현 제공,
    //              파생 클래스는 기본 구현 사용하거나, 다시 만들수 있다
    
    // 추상 메소드 : 기반 클래스가 구현없이 이름만 약속하는 것
    //              파생 클래스는 반드시 구현해야 한다

//  public virtual void Draw() { WriteLine("Draw Shape"); }

    public abstract void Draw();
    public abstract Shape Clone();
    
    // 추상 메소드 : 파생 클래스가 반드시 만들어야 한다.
    
    // 아래 메소드도 추상으로 하면 파생 클래스가 반드시 만들어야 합니다.
    // 혹시 "다시 만드는 것을 옵션" 으로 하려면 아래 처럼 virtual 로 하고
    // 기본(면적 구할수 없음을 나타내는 ) 값  반환
    public virtual int GetArea() { return -1; }
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


