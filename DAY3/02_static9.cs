// C# entry point 규칙 
// => 임의의 클래스를 만들고
// => Main 이라는 이름을 가진 static method 를 만들어야 한다.

// 프로그램이 실행되면
// 1. 사용자가 작성한 모든 클래스를 조사해서 "Main" 이라는 이름의
//    static method 를 찾습니다.
// => "Main static method 를 가진 클래스는 반드시 한개만 있어야 합니다.

// 2. Main 은 static method 이므로 "Program" 객체를 만들필요 없이
//    "Program.Main()" 처럼 호출됩니다.

class Program
{
    public void M1() { }
    public static void M2() { }

    public static void Main()
    {
    }
}