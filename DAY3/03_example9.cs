abstract class Shape
{
    public abstract void Draw();
}

class Rect : Shape
{
    // 규칙 #2. 추상 클래스에서 상속 받는 경우
    //          반드시 추상 메소드 구현해야 합니다. 
    //          만들지 않으면 에러!
    public override void Draw() { }
}

class Program
{
    public static void Main()
    {

    }
}