using static System.Console;

// 핵심 #7.

class Shape
{
    private int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }

    // 자신의 복사본을 만드는 가상 메소드는 널리 알려진 디자인 기술
    public virtual Shape Clone()
    {
        Shape s = new Shape(); // 새로운 Shape 만들고
        s.color = color; // 자신의 모든 속성을 동일하게 복사
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
            else if ( cmd == 8 )
            {
                Console.Write("몇번째 만들었던 도형을 복제할까요 >> ");
                int k = int.Parse( Console.ReadLine());

                // k 번째 도형의 복사본을 생성해서 s 에 추가합니다.
                // 어떻게 만들어야 할까요 ?
                // k 번째 도형은 어떤 타입일까요 ?

                // 아래 처럼 했다면 좋지 않은 디자인
                // OCP 를 만족할수 없는 코드!!
                /*
                if (s[k] is Rect)
                {
                }
                else if (s[k] is Circle)
                {
                }
                */

                // k 번째 도형이 무엇인지 알필요 없다.
                s.Add( s[k].Clone() );  // k번째 도형에 복사본을 요청
                                        // 하면 된다.
                                        // 다형성 활용

                // 객체지향 언어에서 종종 사용하는 격언
                // Don't Ask Do It ( 물어보지 말고, 시켜라)

            }
        }
    }
}


