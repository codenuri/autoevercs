using static System.Console;

// 결국 가상함수는
// => Shape 참조로 도형객체를 관리할때
// => Rect 가 가상함수를 override 하면 새로 만든것 호출해 달라는것

// 실전이라면!!
// 1. 기반 클래스인 Shape 를 먼저 설계 합니다.
// => 모든 도형의 공통의 특징을 생각해서 Shape  에 반드시 넣어야 합니다.
// => "Draw()", "GetArea()", "SetColor()", "Move()" 등....
// => Shape 에 Draw 가 있어야 Shape 참조로 Draw 호출 가능


// 2. Shape 의 메소드 중에서
// => 파생클래스(Rect, Circle) 이 override 하게 되는 것은 virtual  로
// => 파생클래스(Rect, Circle) 이 override 할 필요 없다면 non-virtual  로

// 3. Shape 가 완성되면.. 이제 규칙이 생겼습니다.
// => Rect, Circle 등에서 다시 만들 함수가 결정된것(Draw(), GetArea())
// => 팀원이 각각의 도형을 이제 규칙 대로 설계하면 됩니다.


// 4. 미래에 새로운 도형이 필요해도
// => 기존 코드 수정없이 추가할수 있습니다.

// 이런내용을 좀더 학습하려면
// => "디자인 패턴" 을 공부하세요 

class Shape
{
    public int color = 0;

    // 아래 메소드는 virtual 으로 할까요 ? non-virtual 로 할까요 ?
    // => 아래 메소드는 파생 클래스가 override 할 이유 없습니다.
    // => non-virtual 이 좋습니다.
    // => virtual 로 해도 문제가 되지 않는데, 대신, virtual 은 약간의 성능저하!!
    public void SetColor(int c) { color = c; }


    // virtual ? non-virtual
    // => 모든 도형은 면적을 구하는 방법이 다릅니다.
    // => 각 도형이 override 해야 합니다.
    // => 반드시 virtual
    public virtual int GetArea() { return 0; }



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
        List<Shape> c = new List<Shape>();

        while (true)
        {
            int cmd = int.Parse(ReadLine());

            if (cmd == 1) { c.Add(new Rect()); }
            else if (cmd == 2) { c.Add(new Circle()); }
            else if (cmd == 9)
            {
                foreach (Shape s in c)
                {
                    s.Draw();   
                }
            }
        }
    }
}
