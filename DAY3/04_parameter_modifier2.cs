using static System.Console;

class MyMath
{
    // AddSub
    // 1, 2 ������ ���� ��ȯ������
    // 1, 2 ������ ���� 3��° ���ڿ� ��� �ٲ�.
    // ref : R/W �� ��� �ϰڴٴ� �ǹ�, 
    //       �ʱ�ȭ�� ������ ���� ����

    // out : W �� �ϰڴٴ� �ǹ�
    //       �ʱ�ȭ ���� ���� ������ ����

    public static int AddSub(int a, int b, out int ret)
    {
        ret = a - b;
        return a + b;
    }
}
class Program
{
    public static void Main()
    {
//      int ret1 = 0;  // �ʱ�ȭ�� ����
        int ret1;      // �ʱ�ȭ�� �ȵ� ����

        int ret2 = AddSub(5, 3, out ret1);  // ???

        WriteLine($"{ret1}, {ret2}"); 
    }
}