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
        // 38page �׸� ����
        CPoint cp1; // reference type �̹Ƿ� ��ü ������ �ƴ϶�
                    // ���ÿ� ���������� ����

        cp1.x = 10; // runtime-error. ��ü ����.


        SPoint sp1; // ���ÿ� ��ü ������ ������ ������ ȣ�� �ȵ�
                    // �ʱ�ȭ �ȵ� ��ü
        int n = sp1.x; // error. �ʱ�ȭ ���� ������� ������ ����.

        sp1.x = 10; //ok. ����� ����

        SPoint sp2 = new SPoint(1, 1);
                    // �ᱹ sp1 �� ���� �޸� ����������
                    // �����ڰ� ȣ��Ǿ �ʱ�ȭ ��


    }
}

