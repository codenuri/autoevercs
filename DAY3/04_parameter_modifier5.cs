using static System.Console;

// try parse 
class Program
{
	public static void Main()
	{
        // #1. int.Parse() : ���ڿ��� ������ ����
        int n1 = int.Parse("10");    // ok. ����
        int n2 = int.Parse("Hello"); // ����. ���� �߻�


        // int.Parse() : ���н� ���� �߻�, ó������ ������ ����������
        // int.TryParse() : ������ ����� ����� ��ȯ������
        //                  ����/���� ���δ� 2��° ���ڿ� ��� �ݴϴ�.

        bool b = false;
        int n3 = int.TryParse("Hello", ?? b  );
    }
}