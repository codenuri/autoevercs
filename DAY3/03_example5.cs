using static System.Console;

// 핵심 #5. 모든 도형의 공통의 특징은 반드시 기반 클래스에도 있어야 한다.
// => 문법의 규칙이 아닌 "디자인의 규칙"
// => 모든 도형이 Draw()가 있다면  Shape 에도 Draw() 가 있어야 
// => Shape 참조로 Draw() 호출 가능

// 핵심 #6. 기반 클래스 메소드중 파생 클래스가 다시 만들게 되는 것은
// => 대부분 virtual method 로 해야 한다
// => 그래야, Shape 참조로 호출시 Rect, Circle 에서 다시 만든 Draw() 호출

class Shape
{
    private int color = 0;

    public virtual void Draw() { WriteLine("Draw Shape"); }
}



class Rect : Shape
{
    public override void Draw() { WriteLine("Draw Rect"); }
}

class Circle : Shape
{
    public override void Draw() { WriteLine("Draw Circle"); }
}

class Triangle : Shape
{
    public override void Draw() { WriteLine("Draw Triangle"); }
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
                    e.Draw(); // 새로운 도형이 추가되어도 이 한줄은 
                              // 변경되지 않는다, OCP 를 만족하는 좋은 코드

                              // 다형성(Polymorphism)
                              // => 동일한 한줄의 코드가 상황(실제 객체종류)
                              //    에 따라 다르게 동작하는것(결국 가상 메소드)
                              //    OCP 를 만족하는 좋은 코드

                    // 객체지향 언어 3대 특징
                    // 캡슐화 : 필드를 private 보호해서 안전성 증가
                    // 상속   : 공통의 특징을 기반클래스에,
                    //          이 문법 때문에 List<Shape> 가능
                    // 다형성 : e.Draw() 다양한 도형을 그릴수 있는 특징
                    //         OCP 를 만족하는 좋은 코딩 스타일
                    //          
                }
            }
        }
    }
}


