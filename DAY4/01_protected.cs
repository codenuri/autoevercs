// 접근지정자(필드, 메소드, property) 에 대한 접근을 지정하는 키워드
// => 전통적인 객체지향 문법에서는 "3"개 입니다.
// => private, public, protected(상속문법에서만사용)

// C++ : 위 3개만 지원
// 그외 언어: 위 3개 + 각 언어에서 추가한 경우도 있습니다.

// C# : 위 3개 + internal 

class Shape
{
//  private   int color = 0; // 자신의 메소드만 접근 가능
//  protected int color = 0; // 자신의 메소드 + 파생클래스 메소드 에서 접근가능
//  public int color = 0;    // 모든 위치(멤버가 아닌 메소드도)에서 접근 가능. 
    internal int color = 0;  // 동일 모듈(같은 컴파일 단위)
                             // 현재 소스를 .dll 로 빌드한후
                             // 다른 실행파일에서 DLL Load 하는 경우
                             // color 접근 안됨
                             // public 이라면 .exe 에서 접근 가능

    public void SetColor(int c)
    {
        color = c;
    }   
}

class Rect : Shape
{
    public void Draw()
    {
        int c = color; // ?
    }
}

class Program 
{     
    public static void Main()
    {
        Shape s = new Shape();
        s.color = 10; // error
    }

}


