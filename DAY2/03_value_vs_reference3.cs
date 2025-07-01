using static System.Console;


class CPoint
{
    private int x;
    private int y;
    public CPoint(int a, int b) { x = a; y = b; }
}
struct SPoint
{
    private int x;
    private int y;
    public SPoint(int a, int b) { x = a; y = b; }
}
class Program
{
    public static void Main()
    {
        // 38page 그림 참고
        CPoint cp1; // reference type 이므로 객체 생성이 아니라
                    // 스택에 참조변수만 생성

        cp1.x = 10; // runtime-error. 객체 없음.


        SPoint sp1; // 스택에 객체 생성이 되지만 생성자 호출 안됨
                    // 초기화 안된 객체
        int n = sp1.x; // error. 초기화 되지 않은경우 읽을수 없다.

        sp1.x = 10; //ok. 쓰기는 가능

        SPoint sp2 = new SPoint(1, 1);
                    // 결국 sp1 과 같은 메모리 구조이지만
                    // 생성자가 호출되어서 초기화 됨


    }
}

