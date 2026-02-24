abstract class Shape
{
    // #1. 추상 메소드 의미
    // => 파생 클래스(모든 도형)이 반드시 만들어야 하는 규칙을 설계하는 것
    // => 구현이 아닌, 메소드 이름을 약속
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
        // 규칙 #3. 추상 클래스는 객체 생성 안됩니다.
        // => 메소드 구현이 없으므로
        Shape s = new Shape(); // error. 컴파일 에러

        // 규칙 #4. 추상 클래스라도 참조 타입으로는 사용가능
        Shape s2 = new Rect(); // ok

    }
}