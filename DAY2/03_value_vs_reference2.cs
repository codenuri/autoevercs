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
        // �Ʒ� �ڵ��� �޸� �׸��� 37 page �׸� �Դϴ�.
        // => �ݵ�� �����ؾ� �մϴ�.

        CPoint cp1 = new CPoint(1, 1); // ��ü�� ���� ���� 
                                        // cp1�� ����Ű�� ��

        CPoint cp2 = cp1;       // cp2 �� cp1 �� ���� ��ü ����

        cp2.x = 2;  // ������ ��ü ����

        WriteLine(cp1.x); // 1
        
        //-----------------------------
        SPoint sp1 = new SPoint(1, 1);

        SPoint sp2 = sp1;

        sp2.x = 2; 

        WriteLine(sp1.x); // 1


    }
}

