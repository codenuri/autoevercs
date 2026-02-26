using static System.Console;

class Example
{
    // 함수(메소드)인자 뒤에 디폴트값 사용가능
    // C++ : 지원, 디폴트 파라미터 라는 용어 사용
    // C#  : 지원, Optional 파라미터 라는 용어 사용
    // Python : 지원
    // Java, C, Rust : 모두 지원 안함
    public void M1(int a, int b = 0, int c = 0)
    {
    }
}
class Program
{
    public static void Main()
    {
        Example e = new Example();

        e.M1(1, 2, 3); // 1, 2, 3
        e.M1(1, 2);    // 1, 2, 0
        e.M1(1);       // 1, 0, 0
//        e.M1();        // ERROR
    }
}