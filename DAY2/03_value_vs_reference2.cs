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
        // 아래 코드의 메모리 그림이 37 page 그림 입니다.
        // => 반드시 이해해야 합니다.

        CPoint cp1 = new CPoint(1, 1); // 객체가 힙에 생성 
                                        // cp1이 가리키게 됨

        CPoint cp2 = cp1;       // cp2 는 cp1 과 같은 객체 공유

        cp2.x = 2;  // 공유된 객체 변경

        WriteLine(cp1.x); // 1
        
        //-----------------------------
        SPoint sp1 = new SPoint(1, 1);

        SPoint sp2 = sp1;

        sp2.x = 2; 

        WriteLine(sp1.x); // 1


    }
}

